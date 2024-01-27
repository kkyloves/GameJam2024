using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{   

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
