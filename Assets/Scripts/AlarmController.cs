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
        
        bedRoomController.AddTaskDone();
    }
}
