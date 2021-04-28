using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using pingak9;
using FantomLib;


//#if UNITY_ANDROID && !UNITY_EDITOR
//    AndroidPlugin.ShowTimePickerDialog(defaultTime, resultTimeFormat, callbackGameObject, callbackMethod, style);
//#endif

public class TimePicker : MonoBehaviour
{
    public YesNoDialogController yesNo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowYesNo()
    {
        yesNo.Show();
    }
}
