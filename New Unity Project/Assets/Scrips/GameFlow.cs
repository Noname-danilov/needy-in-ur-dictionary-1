using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public Transform aTestObj;
    List<string> questions = new List<string>() { "light blue", "blue", "brown", "green", "fortegreen", "black", "lime", "orange", "pink", "purple" };
    List<string> correctSelection = new List<string>() { "choice 1" }
    public int textPointer;
    // Start is called before the first frame update
    void Start()
    {
        textPointer = Random.Range(0, 11);
    }

    // Update is called once per frame
    void Update()
    {
        aTestObj.GetComponent<TextMesh>().text = questions[textPointer];
    }
}
