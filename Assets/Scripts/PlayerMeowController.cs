using System;
using Script.Managers;
using UnityEngine;

public class PlayerMeowController : MonoBehaviour
{
    public static PlayerMeowController Instance;
    [SerializeField] private GameObject meowSoundPrefab;
    [SerializeField] private GameObject meowSoundSpawnPosition;

    private Action triggerCallback;
    private Action noNeedSadBoyTriggerCallback;

    private TaskController taskController;

    private bool canMeow = true;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        Instance = this;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void ResetCanMeow()
    {
        canMeow = true;
    }

    private void Update()
    {
        if (canMeow)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (noNeedSadBoyTriggerCallback != null)
                {
                    noNeedSadBoyTriggerCallback.Invoke();

                    Instantiate(meowSoundPrefab, meowSoundSpawnPosition.transform.position, Quaternion.identity);
                    canMeow = false;
                    
                    SoundManager.Instance.PlayMeowSFX();

                    Invoke(nameof(ResetCanMeow), 3f);

                    if (SadBoyController.Instance != null)
                    {
                        SadBoyController.Instance.MoveTowardCat(transform.position, triggerCallback, taskController);
                    }
                }
            }
            //SadBoyController.Instance.MoveTowardCat(transform, triggerCallback);
        }

        if (transform.position.y > -4f)
        {
            spriteRenderer.sortingOrder = 4;
        }
        else
        {
            spriteRenderer.sortingOrder = 10;
        }
        
    }

    public void SetForceTrigger(Action triggerCallback)
    {
        noNeedSadBoyTriggerCallback = triggerCallback;
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.TryGetComponent(out TaskController itemController))
        {
            triggerCallback = itemController.TriggerCallback;
            itemController.OpenHighlights();
            taskController = itemController;
        }

        if (col.gameObject.TryGetComponent(out DividerController dividerController))
        {
            CameraController.Instance.SetCameraPosition(dividerController.CameraPoint);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out TaskController itemController))
        {
            triggerCallback = null;
            itemController.CloseHighlights();
            taskController = null;
        }

        // if (other.gameObject.TryGetComponent(out DividerController dividerController))
        // {
        //     CameraController.Instance.SetCameraPosition(dividerController.CameraPoint);
        // }
    }
}