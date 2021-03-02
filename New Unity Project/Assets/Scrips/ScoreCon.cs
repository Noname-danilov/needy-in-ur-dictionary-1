using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCon : MonoBehaviour
{
    private int sc = 5;



    void Start()
    {
        LoadPrefs();
    }

    private void OnApplicationQuit()
    {
        SavePrefs();
    }

    public void SavePrefs()
    {

    }

    private void LoadPrefs()
    {
        throw new NotImplementedException();
    }




    public string ToJson()
    {
        return JsonUtility.ToJson(obj: Word);
    }

    
}
