using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_for_new_word : MonoBehaviour
{
    public GameObject prefab;
    public GameObject canvas;
    Vector3 brickPosition = new Vector3(250, 700, 0);

    void Update()
    {

     
    }

    public void OnMouseClick ()
    {
      
        Instantiate(prefab, brickPosition, Quaternion.Euler(0, 0, 0), canvas.transform);
        brickPosition += new Vector3(0, -100, 0);
    }
}
