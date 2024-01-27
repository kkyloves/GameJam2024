using System;
using DG.Tweening;
using UnityEngine;

public class SadBoyController : MonoBehaviour
{
    public static SadBoyController Instance;
    [SerializeField] private float moveSpeed;

    private void Awake()
    {
        Instance = this;
    }

    public void MoveTowardCat(Transform targetPosition, Action triggerCallback)
    {
        transform.DOMoveX(targetPosition.position.x, moveSpeed).OnComplete(() =>
        {
            triggerCallback?.Invoke();
        });
    }
}
