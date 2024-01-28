using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Script.Managers;
using UnityEngine;

public class KitchenController : MonoBehaviour
{
    [SerializeField] private GameObject[] dividersToSetOn;
    [SerializeField] private GameObject[] dividersToSetOff;
    [SerializeField] private AudioSource bgm;

    private int taskDone;

    
    public void AddTaskDone()
    {
        taskDone++;

        if (taskDone == 2)
        {
            foreach (var item in dividersToSetOn)
            {
                item.SetActive(true);
            }
            
            foreach (var item in dividersToSetOff)
            {
                item.SetActive(false);
            }
            
            SoundManager.Instance.PlayNextLevelSFX();
            bgm.DOFade(0f, 0.3f).SetUpdate(true).OnComplete(() => { bgm.Pause(); });
        }
    }
}
