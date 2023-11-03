using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void ShowAdv();


    public void PlayGame()
    {
        ShowAdv();
        Time.timeScale = 0f;
        AudioListener.pause = true;
       
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void AfterAds()
   {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void ExitGame()
    {
        Debug.Log("Вы вышли из игры");
        Application.Quit();
    }

    public void InsteadAds()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
