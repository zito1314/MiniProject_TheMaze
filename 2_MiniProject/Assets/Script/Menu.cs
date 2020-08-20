using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{


    public void StartButton()
    {
        SceneManager.LoadScene("Level2");
        print("LOADING SCRENE.......");
    }

    public void QuitButton()
    {
        Application.Quit();
        print("QUIT");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level2");
        print("RESTART....");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
        print("Menu....");
    }
}
