using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer highlights;
    
    private Action triggerCallback;
    public Action TriggerCallback => triggerCallback;

    private void Awake()
    {
        CloseHighlights();
    }

    public void SetTriggerCallback(Action triggerCallback)
    {
        this.triggerCallback = triggerCallback;
        this.triggerCallback += () =>
        {
            highlights.enabled = false;
        };
    }

    public void OpenHighlights()
    {
        highlights.DOFade(0.5f, 0.5f);
    }

    public void CloseHighlights()
    {
        highlights.DOFade(0f, 0.5f);
    }
}