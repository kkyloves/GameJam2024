using Script.Managers;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class BedRoomController : MonoBehaviour
{
    [SerializeField] private Sprite defaultSprite;
    [SerializeField] private SpriteRenderer bedSpriteRenderer;
    [SerializeField] private string[] bedMessages;
    [SerializeField] private TypeWriterEffect typeWriterEffect;
    [SerializeField] private GameObject sadBoyController;
    [SerializeField] private Light2D bathroomLight2D;
    [SerializeField] private GameObject[] dividersToSetOn;
    [SerializeField] private GameObject[] dividersToSetOff;

    private int wakeUpCounter;
    private int taskDone;

    private void Start()
    {
        PlayerMeowController.Instance.SetForceTrigger(TurnOffLamp);
    }

    public void AddTaskDone()
    {
        taskDone++;

        if (taskDone == 2)
        {
            bathroomLight2D.enabled = true;

            foreach (var item in dividersToSetOn)
            {
                item.SetActive(true);
            }
            
            foreach (var item in dividersToSetOff)
            {
                item.SetActive(false);
            }
            
            SoundManager.Instance.PlayNextLevelSFX();
        }
    }

    public void TurnOffLamp()
    {
        wakeUpCounter++;
        Debug.Log(bedMessages[1]);

        if (wakeUpCounter.Equals(2))
        {
            typeWriterEffect.SetText(bedMessages[0]);
        }
        
        if (wakeUpCounter.Equals(4))
        {
            typeWriterEffect.SetText(bedMessages[1]);
        }
        
        if (wakeUpCounter.Equals(6))
        {
            typeWriterEffect.SetText(bedMessages[2]);
        }

        if (wakeUpCounter.Equals(8))
        {
            sadBoyController.SetActive(true);
            bedSpriteRenderer.sprite = defaultSprite;
        }
        
        
        //GetComponent<SpriteRenderer>().sprite = defaultSprite;
    }

}
