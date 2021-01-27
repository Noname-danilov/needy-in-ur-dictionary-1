using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHider : MonoBehaviour
{
    public Button create_button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableCreateButton()
    {
        create_button.interactable = true;
    }
}
