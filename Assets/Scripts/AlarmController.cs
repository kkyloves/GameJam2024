using Script.Managers;
using UnityEngine;

public class AlarmController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private BedRoomController bedRoomController;
    
    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffAlarm);
    }

    public void TurnOffAlarm()
    {
        SoundManager.Instance.StopAlarmClockSFX();
        animator.enabled = false;
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
        
        SoundManager.Instance.PlayIdleLifeSucksSFX();
        Invoke(nameof(TakeoutBath), 2f);
    }
    
    private void TakeoutBath()
    {
        SadBoyController.Instance.ResetToothbrush();
        bedRoomController.AddTaskDone();
    }
}
