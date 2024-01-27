using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LampController : MonoBehaviour
{
    [SerializeField] private Sprite turnOffSprite;
    [SerializeField] private Light2D spotLight;

    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffLamp);
    }

    public void TurnOffLamp()
    {
        GetComponent<SpriteRenderer>().sprite = turnOffSprite;
        spotLight.enabled = false;
    }
}
