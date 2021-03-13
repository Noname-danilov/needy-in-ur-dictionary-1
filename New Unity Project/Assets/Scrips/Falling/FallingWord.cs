using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class FallingWord
{
	public string word;
	private int typeIndex;

	WordDisplay display;

	public FallingWord(string _word, WordDisplay _display)
	{
		this.word = _word;
		typeIndex = 0;

		display = _display;
		display.SetWord(word);
	}

	public char GetNextLetter()
	{
		return word[typeIndex];
	}

	public void TypeLetter()
	{
		typeIndex++; // Remove letter on the screen
		display.RemoveLetter();
	}

	public bool WordTyped()
	{
		bool wordTyped = (typeIndex >= word.Length);
		if (wordTyped)
		{
			display.RemoveWord(); // Remove word on the screen
		}
		return wordTyped;
	}
}
