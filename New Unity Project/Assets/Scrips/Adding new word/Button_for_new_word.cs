using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button_for_new_word : MonoBehaviour
{
    public WordTransfer wordTransfer;
    public GameObject InputPrefab;
    public GameObject canvas;
    public Vector3 brickPosition = new Vector3(150, 450, 0);
    //public GameObject inst1;
    //public GameObject inst2;
    


    WordManager wordManager;
    
    void Update()
    {

     
    }

     void Start()
    {
        wordManager = FindObjectOfType<WordManager>();

        wordTransfer.inputField_1 = Instantiate(InputPrefab, brickPosition, Quaternion.Euler(0, 0, 0), canvas.transform);
        wordTransfer.inputField_2 = Instantiate(InputPrefab, brickPosition - new Vector3(0, 150, 0), Quaternion.Euler(0, 0, 0), canvas.transform);

        Word word = wordManager.words[Random.Range(0, wordManager.words.Count)];

        wordManager.random_word = word;

        wordTransfer.inputField_1.GetComponent<TMP_InputField>().text = word.foreign_word;

        //inst1 = Instantiate(InputPrefab, brickPosition, Quaternion.Euler(0, 0, 0), canvas.transform);     

        //inst2 = Instantiate(InputPrefab, brickPosition - new Vector3(0, 25, 0), Quaternion.Euler(0, 0, 0), canvas.transform);


        //button_1.GetComponent<WordTransfer>().inputField_1 = inst1;
        //button_1.GetComponent<WordTransfer>().inputField_2 = inst2;

       
        //GetComponent<TMP_InputField>().text = word.foreign_word;
        //inst1.GetComponent<TMP_InputField>().text = word.foreign_word;

    }

    
}
