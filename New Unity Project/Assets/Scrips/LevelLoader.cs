using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddingNewWord()
    {
        StartCoroutine(LoadLevel(2));
    }

    public void ModeSelection()
    {
        StartCoroutine(LoadLevel(3));
    }

    public void FlashCards()
    {
        StartCoroutine(LoadLevel(4));
    }

    public void Quiz()
    {
        StartCoroutine(LoadLevel(5));
    }

    /// <summary>
    /// Какой-то тупой метод
    /// </summary>
    /// <param name="levelIndex">"Это индекс уровня (сцены)</param>
    /// <returns></returns>
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start"); //Play animation
        Debug.Log("Loading Level...");

        yield return new WaitForSeconds(transitionTime); //Wait

        SceneManager.LoadScene(levelIndex);  //Load scene
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        LoadLevel(SceneManager.GetActiveScene().buildIndex);
        
        Application.Quit();
    }


    private void OnApplicationQuit()
    {
        //StartCoroutine(LoadLevel(1));

    }

}
