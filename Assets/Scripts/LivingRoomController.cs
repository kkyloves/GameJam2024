using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomController : MonoBehaviour
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
            
            //show cutscene
        }
    }
}
