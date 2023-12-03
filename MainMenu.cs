using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void PlayNight ()
    {
        SceneManager.LoadScene("NightTime");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
