using UnityEngine;

public class AlarmController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private Sprite defaultSprite;

    private void Start()
    {
        Debug.Log("dassssss");

        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffAlarm);
    }

    public void TurnOffAlarm()
    {
        Debug.Log("SADDDD");
        animator.enabled = false;
        GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }
}
