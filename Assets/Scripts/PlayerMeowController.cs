using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMeowController : MonoBehaviour
{
    private Action triggerCallback;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SadBoyController.Instance.MoveTowardCat(transform, triggerCallback);
        }
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