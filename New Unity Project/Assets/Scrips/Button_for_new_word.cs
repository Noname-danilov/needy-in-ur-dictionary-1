using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_for_new_word : MonoBehaviour
{
    public GameObject prefab;
    public GameObject canvas;
    Vector3 brickPosition = new Vector3(250, 700, 0);
    public GameObject inst1;
    public GameObject inst2;
    public GameObject button_1;
    void Update()
    {

     
    }

    public void OnMouseClick ()
    {
       GetComponent<Button>().interactable = false;
        inst1 = Instantiate(prefab, brickPosition, Quaternion.Euler(0, 0, 0), canvas.transform);
        brickPosition += new Vector3(0, -100, 0);
    
        inst2 = Instantiate(prefab, brickPosition, Quaternion.Euler(0, 0, 0), canvas.transform);
        brickPosition += new Vector3(0, -200, 0);


        button_1.GetComponent<WordTransfer>().inputField_1 = inst1;
        button_1.GetComponent<WordTransfer>().inputField_2 = inst2;

        

    }
}
