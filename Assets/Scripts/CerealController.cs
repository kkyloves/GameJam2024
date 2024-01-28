using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;

public class CerealController : MonoBehaviour
{    [SerializeField] private KitchenController kitchenController;

    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        SoundManager.Instance.PlayEatingCerealSFX();
        SadBoyController.Instance.SetToothbrush();
        
        Invoke(nameof(TakeoutBath), 10f);
    }
    
    private void TakeoutBath()
    {
        SoundManager.Instance.StopEatingCerealSFX();
        SadBoyController.Instance.ResetToothbrush();
        
        kitchenController.AddTaskDone();
        //bathroomController.AddTaskDone();
    }
}
