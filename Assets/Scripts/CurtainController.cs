using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class CurtainController : MonoBehaviour
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
        spotLight.enabled = true;
    }
}
