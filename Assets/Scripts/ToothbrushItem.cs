using Script.Managers;
using UnityEngine;

public class ToothbrushItem : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }
    
    public void TurnOffLamp()
    {
        //SoundManager.Instance.PlayDoorWindSFX();
        SoundManager.Instance.PlayBrushingTeethSFX();
        SadBoyController.Instance.SetBath();
        
        Invoke(nameof(TakeoutBath), 5f);
    }

    private void TakeoutBath()
    {
        SadBoyController.Instance.GetOutBath();
        SoundManager.Instance.StopToothbrushSFX();
    }
}
