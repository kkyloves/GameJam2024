using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;

public class DrinkWaterController : MonoBehaviour
{
    [SerializeField] private KitchenController kitchenController;
    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        SoundManager.Instance.PlayDrinkingSFX();
        SadBoyController.Instance.SetToothbrush();
        
        Invoke(nameof(TakeoutBath), 4f);
    }
    
    private void TakeoutBath()
    {
        SoundManager.Instance.StopDrinkingWaterSFX();
        SadBoyController.Instance.ResetToothbrush();

        kitchenController.AddTaskDone();
        //bathroomController.AddTaskDone();
    }
}
