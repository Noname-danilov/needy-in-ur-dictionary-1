using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enable : MonoBehaviour
{
    public GameObject gameObject;
    bool TrueFalse;

    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void retarded_funcion()
    {
        gameObject.GetComponent<Text>().enabled = false;
    }
    public void OnMouseClick()
    {

    if (gameObject.GetComponent<Text>().enabled = false;
    {
        gameObject.GetComponent<Text>().enabled = true;
    }

    }


}
