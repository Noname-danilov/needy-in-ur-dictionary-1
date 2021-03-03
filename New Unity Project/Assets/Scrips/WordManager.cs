using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public struct Word
{
    public string foreign_word;// инглиш
    public string native_word;// russian

}
[Serializable]
public class WordManager : MonoBehaviour
{

    public Word random_word;
    public List<Word> words = new List<Word>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
