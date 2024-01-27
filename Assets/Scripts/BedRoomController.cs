using UnityEngine;

public class BedRoomController : MonoBehaviour
{
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private string[] bedMessages;
    [SerializeField] private TypeWriterEffect typeWriterEffect;
    private int wakeUpCounter;

    private void Start()
    {
        PlayerMeowController.Instance.SetForceTrigger(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        wakeUpCounter++;
        Debug.Log(bedMessages[1]);

        if (wakeUpCounter.Equals(1))
        {
            typeWriterEffect.SetText(bedMessages[0]);
        }
        
        if (wakeUpCounter.Equals(5))
        {
            typeWriterEffect.SetText(bedMessages[1]);
        }
        
        if (wakeUpCounter.Equals(10))
        {
            typeWriterEffect.SetText(bedMessages[2]);
        }
        
        
        //GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }

}
