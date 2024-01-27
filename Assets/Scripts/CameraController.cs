using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;
    [SerializeField] private CinemachineVirtualCamera virtualCamera;
    [SerializeField] private Transform[] movePoints;

    private void Awake()
    {
        Instance = this;
    }
    
    public void SetCameraPosition(Transform cameraPosition)
    {
        virtualCamera.Follow = cameraPosition;
        virtualCamera.LookAt = cameraPosition;
    }
}
