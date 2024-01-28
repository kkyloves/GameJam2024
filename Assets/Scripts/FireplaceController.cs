using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;

public class FireplaceController : MonoBehaviour
{
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private LivingRoomController bedRoomController;
    
    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffAlarm);
    }

    public void TurnOffAlarm()
    {
        SoundManager.Instance.PlayChimneyFireSFX();
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
        
        Invoke(nameof(TakeoutBath), 2f);
    }
    
    private void TakeoutBath()
    {
        SadBoyController.Instance.ResetToothbrush();
        bedRoomController.AddTaskDone();
    }
}
