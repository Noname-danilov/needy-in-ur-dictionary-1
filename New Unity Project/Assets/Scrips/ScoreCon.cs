using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCon : MonoBehaviour
{
    string SaveKey = "ListOfWords";


    void Start()
    {
        LoadPrefs();
    }

    void OnApplicationQuit()
    {
        SavePrefs();
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetString(SaveKey, FindObjectOfType<SaveData>().ToJson()); // (ScoreKey, )
        PlayerPrefs.Save();
    }

    private void LoadPrefs()
    {
        string JsonData = PlayerPrefs.GetString(SaveKey, "No Saved Data");
        Debug.Log($"Loaded Data: {JsonData}");
        FindObjectOfType<SaveData>().LoadFromJson(JsonData);
        Debug.Log($"Data Sucsessfully Loaded");

    }
    
   
}
