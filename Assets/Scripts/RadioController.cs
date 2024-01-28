using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script.Managers;
using UnityEngine;

public class RadioController : MonoBehaviour
{
    [SerializeField] private LivingRoomController bedRoomController;
    [SerializeField] private GameObject radioAnimated;
    [SerializeField] private AudioSource bgm;

    private void Start()
    {
        gameObject.GetComponent<TaskController>().SetTriggerCallback(TurnOffAlarm);
    }

    public void TurnOffAlarm()
    {
        SoundManager.Instance.PlayRadioOnSFX();

        Invoke(nameof(TakeoutBath), 2f);
    }

    private void TakeoutBath()
    {
        SadBoyController.Instance.ResetToothbrush();
        radioAnimated.gameObject.SetActive(true);
        bedRoomController.AddTaskDone();
        
        bgm.DOFade(0.5f, 0f).OnComplete(() => { bgm.Play(); });

        gameObject.SetActive(false);
    }
}