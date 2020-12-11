using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform aTestObj;
    List<string> questions = new List<string>() { "", "Purple", "Tan", "Brown", "Green", "White", "Black", "Lime", "Orange", "Pink" };
    List<string> correctSelection = new List<string>() { "", "choice 2", "choice 3", "choice 1", "choice 1", "choice 3", "choice 2", "choice 2", "choice 2", "choice 2", "choice 2" };
    public static string currentSelection;
    public static int textPointer;

    // Start is called before the first frame update
    void Start()
    {
        textPointer = Random.Range (1, 7);
    }

    // Update is called once per frame
    void Update()
    {
        aTestObj.GetComponent<TextMesh>().text = questions[textPointer];

        if (currentSelection==correctSelection[textPointer])
        {
            Debug.Log("Correct");
        }
    }
}
