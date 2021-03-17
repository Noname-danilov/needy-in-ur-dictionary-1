using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enable : MonoBehaviour
{
    public GameObject gameObject;
    bool TrueFalse = true;

    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void retarded_funcion()
    {
        if (TrueFalse)
        {
            gameObject.GetComponent<Text>().enabled = false;
            TrueFalse = false;
        }
        else
        {
            gameObject.GetComponent<Text>().enabled = true;
            TrueFalse = true;
        }
        
    }

    //public void OnMouseClick()
    //{
    //    if TrueFalse.GetComponent<Text>().enabled = false;
    //    {
    //        TrueFalse.GetComponent<Text>().enabled = true;
    //    }

    //}
    public void retarded_funcion2()
    {
        
        gameObject.GetComponent<Text>().enabled = true;
    }



}
