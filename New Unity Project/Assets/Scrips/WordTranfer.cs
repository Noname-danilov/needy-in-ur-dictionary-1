using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTranfer : MonoBehaviour
{
    public string theWord;
    public CameObject InputField;
    public CameObject textDisplay;

    public void StoreWord()
    {
        theWord = InputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "ur word is " + theWord + " )";
    }
}
