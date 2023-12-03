using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MasterVolume", volume);
        Debug.Log(volume);

    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
        //Add Saving here
    }

    public void GoBackToGame(){
        SceneManager.LoadScene(2);
    }
}
