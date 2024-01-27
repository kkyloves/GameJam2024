using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SadBoyController : MonoBehaviour
{
    public static SadBoyController Instance;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Sprite idleSprite;
    [SerializeField] private Sprite[] walkingSprites;

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
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out TaskController taskController))
        {
            if (this.taskController == taskController)
            {
                taskController.TriggerCallback?.Invoke();
                cantMove = true;
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

                Debug.Log(Mathf.Abs(transform.position.x - targetPosition.x));
                if (Mathf.Abs(transform.position.x - targetPosition.x) < 0.5f)
                {
                    cantMove = true;
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
        doingSomething = true;
        GetComponent<SpriteRenderer>().DOFade(0f, 1f);
    }

    public void GetOutBath()
    {
        doingSomething = false;
        GetComponent<SpriteRenderer>().DOFade(1f, 1f);
    }
}