using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WordTransfer : MonoBehaviour
{
    public string CheckWord1;
    public string CheckWord2;
    public GameObject inputField_1;
    public GameObject inputField_2;
    public GameObject textDisplay;

    WordManager wordManager;


    void Start()
    {
        wordManager = FindObjectOfType<WordManager>();
    }

    public void StoreWord()
    {
        FindObjectOfType<ButtonHider>().EnableCreateButton();

        CheckWord1 = inputField_1.GetComponent<TMP_InputField>().text;
        CheckWord2 = inputField_2.GetComponent<TMP_InputField>().text;

        if (CheckWord2 == wordManager.random_word.native_word)
        {
            textDisplay.GetComponent<Text>().text = "Congratz!";
        }
        else
        {
            textDisplay.GetComponent<Text>().text = "You f'd up!";
        }

        //textDisplay.GetComponent<Text>().text = "ur word is:" + CheckWord1 + " - " + CheckWord2;

        Word word = wordManager.words[Random.Range(0, wordManager.words.Count)];

        wordManager.random_word = word;
        inputField_1.GetComponent<TMP_InputField>().text = word.foreign_word;
        Debug.Log(word.foreign_word);
        inputField_2.GetComponent<TMP_InputField>().text = "";


    } 

    /* public void AddNewWord()
    {

        theWord1 = inputField_1.GetComponent<TMP_InputField>().text;
        theWord2 = inputField_2.GetComponent<TMP_InputField>().text;

        wordManager.words.Add(new Word()
        {
            foreign_word = theWord1,
            native_word = theWord2
        });


    } */

}
