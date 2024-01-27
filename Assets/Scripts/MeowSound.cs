using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowSound : MonoBehaviour
{
    [SerializeField] private TypeWriterEffect typeWriterEffect;
    public void Awake()
    {
        typeWriterEffect.SetText("MEOW!");
        Invoke(nameof(DestroyThis), 3f);
    }

    private void DestroyThis()
    {
        Destroy(gameObject);
    }
}
