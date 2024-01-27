using UnityEngine;
using System.Collections;
using DG.Tweening;
using TMPro;

public class TypeWriterEffect : MonoBehaviour
{

    [SerializeField] private float typeWriterSpeed = 0.125f;
    [SerializeField] private float fadeSpeed = 5f;
    [SerializeField] private TextMeshProUGUI txt;
    
    private string story;
    
    public void SetText(string message)
    {
        story = message;
        txt.text = string.Empty;
        txt.DOFade(1f, 0f);
        StartCoroutine (nameof(PlayText));
    }

    private IEnumerator PlayText()
    {
        foreach (var c in story) 
        {
            txt.text += c;
            yield return new WaitForSeconds (typeWriterSpeed);
        }

        while (txt.text.Length < story.Length)
        {
            yield return null;
        }

        txt.DOFade(0f, fadeSpeed);
    }

}