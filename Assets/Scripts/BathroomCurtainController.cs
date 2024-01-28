using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;

public class BathroomCurtainController : MonoBehaviour
{
    [SerializeField] private Sprite turnOnCurtain;
    [SerializeField] private Sprite turnOffCurtain;
    [SerializeField] private BathroomController bathroomController;

    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        //SoundManager.Instance.PlayDoorWindSFX();
        GetComponent<SpriteRenderer>().sprite = turnOnCurtain;
        SoundManager.Instance.PlayShowerSFX();
        SadBoyController.Instance.SetBath();
        
        Invoke(nameof(TakeoutBath), 5f);
    }

    private void TakeoutBath()
    {
        GetComponent<SpriteRenderer>().sprite = turnOffCurtain;
        SadBoyController.Instance.GetOutBath();
        SoundManager.Instance.StopShowerSFX();
        
        bathroomController.AddTaskDone();
    }
}
