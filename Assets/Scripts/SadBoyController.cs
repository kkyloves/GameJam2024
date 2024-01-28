using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script.Managers;
using UnityEngine;

public class SadBoyController : MonoBehaviour
{
    public static SadBoyController Instance;
    [SerializeField] private GameObject meowSoundPrefab;
    [SerializeField] private Transform meowSoundSpawnPosition;
    
    [SerializeField] private float moveSpeed;
    [SerializeField] private Sprite idleSprite;
    [SerializeField] private Sprite[] walkingSprites;
    [SerializeField] private Sprite workingSprite;

    private Vector2 targetPosition;
    private Action triggerCallback;

    private float defaultY;
    private bool cantMove;
    private bool doingSomething;

    private SpriteRenderer spriteRenderer;
    private TaskController taskController;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultY = transform.position.y;
        Instance = this;

        targetPosition = transform.position;
        doingSomething = true;
        
        var meowSound = Instantiate(meowSoundPrefab, meowSoundSpawnPosition.transform.position, Quaternion.identity);
        meowSound.GetComponent<MeowSound>().SetText("WHAT DO YOU NEED ON ME ?!!");
        
        Invoke(nameof(ResetDoingSomething), 3f);
    }

    private IEnumerator MoveAnimation()
    {
        var walkerCount = 0;
        while (true)
        {
            if (cantMove || doingSomething)
            {
                break;
            }

            if (walkerCount >= walkingSprites.Length)
            {
                walkerCount = 0;
            }

            spriteRenderer.sprite = walkingSprites[walkerCount];
            walkerCount++;
            yield return new WaitForSeconds(0.3f);
        }
    }

    public void MoveTowardCat(Vector2 targetPosition, Action triggerCallback, TaskController taskController)
    {
        if (!doingSomething)
        {
            cantMove = false;
            this.taskController = taskController;
            this.targetPosition = targetPosition;
            this.triggerCallback = triggerCallback;

            StartCoroutine(MoveAnimation());
            SoundManager.Instance.PlayWalkSFX();
        }
    }

    private void ResetDoingSomething()
    {
        spriteRenderer.sprite = idleSprite;
        doingSomething = false;
    }
    

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out TaskController taskController))
        {
            if (this.taskController == taskController)
            {
                SoundManager.Instance.StopWalkSFX();

                taskController.TriggerCallback?.Invoke();
                spriteRenderer.sprite = workingSprite;
                doingSomething = true;
                
                //Invoke(nameof(ResetDoingSomething), 2f);
            }
        }
    }

    private void Update()
    {
        if (!doingSomething)
        {
            if (!cantMove)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector2(targetPosition.x, defaultY), moveSpeed * Time.deltaTime);
                if (Mathf.Abs(transform.position.x - targetPosition.x) < 0.5f)
                {
                    cantMove = true;
                    SoundManager.Instance.StopWalkSFX();
                    spriteRenderer.sprite = idleSprite;
                }
                
                spriteRenderer.flipX = targetPosition.x < transform.position.x; 
            }
        }
    }

    private void MoveTowardCatDelay()
    {
        // transform.DOMoveX(targetPosition.x, moveSpeed).OnComplete(() =>
        // {
        //     triggerCallback?.Invoke();
        // });
    }

    public void SetBath()
    {
        spriteRenderer.sprite = workingSprite;
        doingSomething = true;
        GetComponent<SpriteRenderer>().DOFade(0f, 1f);
    }
    
    public void SetToothbrush()
    {
        spriteRenderer.sprite = workingSprite;
        doingSomething = true;
    }

    public void ResetToothbrush()
    {
        spriteRenderer.sprite = idleSprite;
        doingSomething = false;
    }

    public void GetOutBath()
    {
        spriteRenderer.sprite = idleSprite;

        doingSomething = false;
        GetComponent<SpriteRenderer>().DOFade(1f, 1f);
    }
}