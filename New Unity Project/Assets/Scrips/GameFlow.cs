using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFlow : MonoBehaviour
{
    public Transform aTestObj;
    public Transform sysTextObj;
    public Transform scoreTextObj;

    List<string> questions = new List<string>() {"", "Purple", "Tan", "Brown", "Green", "White", "Black", "Lime", "Orange", "Pink", "Kill", "Blue", "Fortegreen", "Ligth Blue", "Red", "Report", "shh", "Yellow", "All" };
    List<string> correctSelection = new List<string>() {"", "choice2", "choice3", "choice1", "choice1", "choice3", "choice1", "choice2", "choice2", "choice2", "choice2", "choice1", "choice1", "choice2", "choice3", "choice3", "choice3", "choice3", "choice1" };
    
    public static string currentSelection;
    public static int textPointer;
    public static string playerClicked = "N";
    public static string loadQuestion = "Y";
    public static string cleartext = "N";

    public static int totalScore = 0;

    public static int askedQuestions = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameFlow.askedQuestions>5)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (loadQuestion == "Y")
        {
            textPointer = Random.Range(1, 7);
            aTestObj.GetComponent<TextMesh>().text = questions[textPointer];
        }

        if (playerClicked == "Y")
        {
            if (currentSelection == correctSelection[textPointer])
            {
                //Debug.Log("Correct");
                playerClicked = "N";
                sysTextObj.GetComponent<TextMesh>().text = "Correct";
                totalScore += 1;
                scoreTextObj.GetComponent<TextMesh>().text = "Score : " + totalScore;
            }
            else
            {
                sysTextObj.GetComponent<TextMesh>().text = "Incorrect";
            }
        }
    }
    void LateUpdate()
    {
        loadQuestion = "N";
        if (cleartext == "Y")
        {
            sysTextObj.GetComponent<TextMesh>().text = "";
            cleartext = "N";
        }
    }
}
