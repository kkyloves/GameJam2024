using System.Collections;
using System.Collections.Generic;
using Script.Managers;
using UnityEngine;

public class BathroomController : MonoBehaviour
{
    [SerializeField] private GameObject[] dividersToSetOn;
    [SerializeField] private GameObject[] dividersToSetOff;
    
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
        }
        
        SoundManager.Instance.PlayNextLevelSFX();
    }
}
