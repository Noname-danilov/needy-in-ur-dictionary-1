using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;
using UnityEngine.Events;
using UnityEngine.UI;
using FantomLib;

public class AddingNewWord : MonoBehaviour
{
    public GameObject InputPrefab;
    public GameObject place;
    public Vector3 brickPosition = new Vector3(150, 450, 0);
    public string AddWord1;
    public string AddWord2;
    public GameObject inputField_n1;
    public GameObject inputField_n2;
    WordTransfer wordTransfer;
    WordManager wordManager;
    public Material textureMat;                 
    public Image image;                
    public bool fitOrientation = true;

    

    // Start is called before the first frame update
    void Start()
    {
        wordTransfer = FindObjectOfType<WordTransfer>();
        wordManager = FindObjectOfType<WordManager>();
 
        inputField_n1 = Instantiate(InputPrefab, brickPosition, Quaternion.Euler(0, 0, 0), place.transform);
        inputField_n2 = Instantiate(InputPrefab, brickPosition - new Vector3(0, 150, 0), Quaternion.Euler(0, 0, 0), place.transform);

        Word word = wordManager.words[Random.Range(0, wordManager.words.Count)];

        wordManager.random_word = word;
        inputField_n1.GetComponent<TMP_InputField>().text = "";
        Debug.Log(word.foreign_word);
        inputField_n2.GetComponent<TMP_InputField>().text = "";


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNewWord()
    {

        AddWord1 = inputField_n1.GetComponent<TMP_InputField>().text;
        AddWord2 = inputField_n2.GetComponent<TMP_InputField>().text;

        wordManager.words.Add(new Word()
        {
            foreign_word = AddWord1,
            native_word = AddWord2
        });

    }
}

