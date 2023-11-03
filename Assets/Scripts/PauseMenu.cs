using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;
    public AudioSource backGround;
  //  public AudioMixerGroup mixerGroup;
  //  public Slider sliderVolume;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

     
    }
    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        backGround.Play();
        PauseGame = false;
    }

    public void Pause() 
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        backGround.Stop();
        PauseGame = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Loading Scena");                                                                                                                                                                                                                                                                                                                                                                                                                                        
    }

  //  public void ToggleMusic(bool enabled)
   // {
     //   if(enabled)
     //   mixerGroup.audioMixer.SetFloat("MasterVolume", 0);
      //  else
        //    mixerGroup.audioMixer.SetFloat("MasterVolume", -80);
   // }
  //  public void ChangeVolume(float volume)
  //  {
        
      // mixerGroup.audioMixer.SetFloat("MasterVolume", Mathf.Log10((volume) * 20));
   // }
}
