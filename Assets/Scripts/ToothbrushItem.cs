using Script.Managers;
using UnityEngine;

public class ToothbrushItem : MonoBehaviour
{
    [SerializeField] private BathroomController bathroomController;

    
    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }
    
    public void TurnOffLamp()
    {
        //SoundManager.Instance.PlayDoorWindSFX();
        SoundManager.Instance.PlayBrushingTeethSFX();
        SadBoyController.Instance.SetToothbrush();
        
        Invoke(nameof(TakeoutBath), 5f);
    }

    private void TakeoutBath()
    {
        SadBoyController.Instance.ResetToothbrush();
        SoundManager.Instance.StopToothbrushSFX();
        
        bathroomController.AddTaskDone();
    }
}
