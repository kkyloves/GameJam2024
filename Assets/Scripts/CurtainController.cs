using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CurtainController : MonoBehaviour
{
    [SerializeField] private Sprite turnOffSprite;
    [SerializeField] private Light2D spotLight;
    [SerializeField] private BedRoomController bedRoomController;


    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        SoundManager.Instance.PlayDoorWindSFX();
        GetComponent<SpriteRenderer>().sprite = turnOffSprite;
        spotLight.enabled = true;
        
        bedRoomController.AddTaskDone();
    }
}
