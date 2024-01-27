using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathroomCurtainController : MonoBehaviour
{
    [SerializeField] private Sprite turnOnCurtain;
    [SerializeField] private Sprite turnOffCurtain;

    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        //SoundManager.Instance.PlayDoorWindSFX();
        GetComponent<SpriteRenderer>().sprite = turnOnCurtain;
        SadBoyController.Instance.SetBath();
        
        Invoke(nameof(TakeoutBath), 5f);
    }

    private void TakeoutBath()
    {
        GetComponent<SpriteRenderer>().sprite = turnOffCurtain;
        SadBoyController.Instance.GetOutBath();
    }
}
