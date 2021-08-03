using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class SaveData : MonoBehaviour
{
    public string ToJson()
    {
        WordManager wordManager = FindObjectOfType<WordManager>();
        string JSON = JsonUtility.ToJson(wordManager); //whole script
        Debug.Log($"ToJson: {JSON}");
        return JSON;
    }

    public void LoadFromJson(string a_Json)
    {
        JsonUtility.FromJsonOverwrite(a_Json, FindObjectOfType<WordManager>());
       //FindObjectOfType<WordManager>().words = ((WordManager)JsonUtility.FromJson(a_Json, typeof(WordManager))).words; 
    }   
}
public interface ISaveable
{
    void PopulateSaveData(SaveData a_SaveData);
    void LoadFromSaveData(SaveData a_SaveData);
}