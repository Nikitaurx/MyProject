using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class GameManager : MonoBehaviour
{
    public bool isFullScreen;
    public AudioMixer audioMixer;

    public void ClickOnStart()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ClickOnSettings()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void ClickOnExit()
    {
        Application.Quit();
    }

    public void Settings_Fullscreen()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
    public void Settings_Audio(float sliderValue)
    {
        audioMixer.SetFloat("masterVolume", sliderValue);
    }
    public void Settings_Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }
    public void Settings_Resolution()
    {
        //для него нужен UnityEngine.UI
    }
    public void ClickOnSave()
    {
        SceneManager.LoadScene("mainMenu");
    }

}

