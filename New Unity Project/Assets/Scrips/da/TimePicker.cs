using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using pingak9;
using FantomLib;

#if UNITY_ANDROID && !UNITY_EDITOR
    AndroidPlugin.ShowTimePickerDialog(defaultTime, resultTimeFormat, callbackGameObject, callbackMethod, style);
#endif

public class TimePicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDialogInfo()
    {
        NativeDialog.OpenDialog("Info popup", "Welcome To Native Popup", "Ok",
            () =>
            {
                Debug.Log("OK Button pressed");
            });
    }

    public void OnDialogConfirm()
    {
        NativeDialog.OpenDialog("Confirm popup", "Do you wants about app?", "Yes", "No",
            () =>
            {
                Debug.Log("Yes Button pressed");
            },
            () =>
            {
                Debug.Log("No Button pressed");
            });
    }
    public void OnDialogNeutral()
    {
        NativeDialog.OpenDialog("Like this game?", "Please rate to support future updates!", "Rate app", "later", "No, thanks",
            () =>
            {
                Debug.Log("Rate Button pressed");
            },
            () =>
            {
                Debug.Log("Later Button pressed");
            },
            () =>
            {
                Debug.Log("No Button pressed");
            });
    }

    public void OnDatePicker()
    {
        NativeDialog.OpenDatePicker(1992, 5, 10,
            (DateTime _date) =>
            {
                Debug.Log(_date.ToString());
            },
            (DateTime _date) =>
            {
                Debug.Log(_date.ToString());
            });
    }
    public void OnTimePicker()
    {
        NativeDialog.OpenTimePicker(
            (DateTime _date) =>
            {
                Debug.Log(_date.ToString());
            },
            (DateTime _date) =>
            {
                Debug.Log(_date.ToString());
            });
    }
}
