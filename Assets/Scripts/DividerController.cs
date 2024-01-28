using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DividerController : MonoBehaviour
{
    [SerializeField] private GameObject otherDivider;
    [SerializeField] private Transform cameraPoint;
    public Transform CameraPoint => cameraPoint;


    public void OpenOtherDivider()
    {
        otherDivider.SetActive(true);
        gameObject.SetActive(false);
    }
}
