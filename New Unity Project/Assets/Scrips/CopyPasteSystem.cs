using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CopyPasteSystem : MonoBehaviour
{
    public TMP_InputField TMP_InputField ;

    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = FindObjectOfType<WordTransfer>().inputField_1.GetComponent<TMP_InputField>().text;
        textEditor.SelectAll();
        textEditor.Copy();
    }

    public void PasteFromClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.multiline = true;//dayn
        textEditor.Paste(); //dimas gey
        FindObjectOfType<WordTransfer>().inputField_1.GetComponent<TMP_InputField>().text = textEditor.text;
    }

}

