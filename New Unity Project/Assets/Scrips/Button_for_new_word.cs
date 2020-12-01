using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_for_new_word : MonoBehaviour
{
    public GameObject prefab;
    public GameObject canvas;
    public Vector3 brickPosition = new Vector3(10, 0, 0);

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            GameObject instance = Instantiate(prefab, transform.position + brickPosition, transform.rotation) as GameObject;
        }
    }

    public void OnMouseClick ()
    {
        Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity, canvas.transform);
    }
}
