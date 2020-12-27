using System.Collections;
using System.Collections.Generic;
//using System.Runtime.Hosting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ModeSelection()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void FlashCards()
    {
        SceneManager.LoadScene(3);
    }

    public void Quiz()
    {
        SceneManager.LoadScene(3);
    }

    public void AddingNewWord()
    {
        SceneManager.LoadScene(4);
    }
}
