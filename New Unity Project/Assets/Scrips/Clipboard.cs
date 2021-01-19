using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clipboard : MonoBehaviour
{
    public InputField inputField;

    public void CopyToClipboard()
    {
        TextEditor textEditor = new TextEditor();
        textEditor.text = innputField.text;
        textEditor.SelectAll();
        textEditor.Copy();
    }

    public void PasteFromClipboard()
    {
        TextEditor textEditor 
    }

}
