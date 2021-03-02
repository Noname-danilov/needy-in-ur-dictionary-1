using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCon : MonoBehaviour
{
    string Amount;

    
    void Start() => LoadPrefs();

    private void OnApplicationQuit()
    {
        SavePrefs();
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetString(Amount, ); // (ScoreKey, )
        PlayerPrefs.Save();
    }

    private void LoadPrefs()
    {
        var AmountOfWords = PlayerPrefs.GetString("Score", "default");
         = AmountOfWords;

    }
    
   
}
