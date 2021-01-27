using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CopyPasteSystem : MonoBehaviour
{
    public TMP_InputField TMP_InputField;

    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = TMP_InputField.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }

    public void PasteFromClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.multiline = true;
        textEditor.Paste();
        TMP_InputField.text = textEditor.text;
    }

}

