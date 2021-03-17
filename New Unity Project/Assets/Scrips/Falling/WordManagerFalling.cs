using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManagerFalling : MonoBehaviour
{
	public List<FallingWord> words;

	public WordSpawner wordSpawner;

	private bool hasActiveWord;
	private FallingWord activeWord;

	//public void Start()
    //{
	//	AddWord();
	//	AddWord();
	//	AddWord();
	//}

	public void AddWord()
	{
		//FallingWord word = new FallingWord(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		List<Word> my_little_words = FindObjectOfType<WordManager>().words;
		string random_foreign_word = my_little_words[Random.Range(0, my_little_words.Count)].foreign_word;
		FallingWord word = new FallingWord(random_foreign_word, wordSpawner.SpawnWord());
		Debug.Log(word.word);

		words.Add(word);
	}

	public void TypeLetter(char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter) //Cheak if letter was next
			{
				activeWord.TypeLetter();
			}
		}
		else
		{
			foreach (FallingWord word in words) //(class variable in List)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{
			hasActiveWord = false;
			words.Remove(activeWord);
		}
	}
}
