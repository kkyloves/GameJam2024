using System;
using UnityEngine;

public class PlayerMeowController : MonoBehaviour
{
    public static PlayerMeowController Instance;

    [SerializeField] private TypeWriterEffect typeWriterEffect;

    private Action triggerCallback;
    private Action noNeedSadBoyTriggerCallback;

    private bool canMeow = true;

    private void Awake()
    {
        Instance = this;
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
                    typeWriterEffect.SetText("MEOW!");
                    canMeow = false;

                    Invoke(nameof(ResetCanMeow), 3f);
                }
            }


            //SadBoyController.Instance.MoveTowardCat(transform, triggerCallback);
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
        }

        // if (other.gameObject.TryGetComponent(out DividerController dividerController))
        // {
        //     CameraController.Instance.SetCameraPosition(dividerController.CameraPoint);
        // }
    }
}