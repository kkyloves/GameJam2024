using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void onQuit()
    {
        Application.Quit();
    }

    public void onCredit()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void onReturnToMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
