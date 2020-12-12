using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questCon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        GameFlow.loadQuestion = "Y";
        GameFlow.cleartext = "Y";
        GameFlow.askedQuestions += 1;

    }
}
