using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordTransfer : MonoBehaviour
{
    public string theWord1;
    public string theWord2;
    public GameObject inputField_1;
    public GameObject inputField_2;
    public GameObject textDisplay;

    public void StoreWord()
    {
        theWord1 = inputField_1.GetComponent<TMP_InputField>().text;
        theWord2 = inputField_2.GetComponent<TMP_InputField>().text;
        textDisplay.GetComponent<Text>().text = "ur word is " + theWord1 + " )" + theWord2;
    }
}
