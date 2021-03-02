using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class SaveData : MonoBehaviour
{
    public string ToJson()
    {
        WordManager wm = FindObjectOfType<WordManager>();
        return JsonUtility.ToJson(wm.words);
    }

   

    public interface ISaveable
    {
        void PopulateSaveData(SaveData a_SaveData);
        void LoadFromSaveData(SaveData a_SaveData);

    }
}