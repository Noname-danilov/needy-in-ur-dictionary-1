using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class WordTransfer : MonoBehaviour
{
    public string theWord;
    public GameObject inputField;
    public GameObject textDisplay;

    public void StoreWord()
    {
        theWord = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "ur word is " + theWord + " )";
    }
}
