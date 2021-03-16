using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text2;
	public float fallSpeed = 1f;

	public void SetWord (string word) // public void Jump (int hight, string type_of_jumper)
	{
		text2.text = word;
	}

	public void RemoveLetter ()
	{
		text2.text = text2.text.Remove(0, 1); 
		text2.color = Color.red;
	}

	public void RemoveWord ()
	{
		Destroy(gameObject);
	}

	private void Update()
	{
		transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f); //Falling
	}
}
