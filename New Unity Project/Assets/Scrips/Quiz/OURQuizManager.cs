//using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class OURQuizManager : MonoBehaviour
{    
    public TMP_Text question;
    public TMP_Text response;
    public Button button_true;
    public Button button_false;
    public TMP_InputField writing_answer;
    public Toggle toggle;



    //Unity doesn't know how to serialize a Dictionary
    public Dictionary<string, Button> questions = new Dictionary<string, Button>();
    public Dictionary<string, string> input_field_questions = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        int choice = Random.Range(0, 2);
        if (choice == 0)
        {
            questions.Add("Почему?", button_true);
        }
        else
        {
            questions.Add("Почему?", button_false);
        }        
        questions.Add("7 + 3", button_false);  // 7 + 3 = false && 7+2 =true
        questions.Add("Сколько у тебя хромосом?", button_true);

        input_field_questions.Add("Да?", "☺");


        question.text = questions.Keys.First();
    }

    // Update is called once per frame
    void Update()
    {
        if (questions.Count == 0)
        {
            button_true.enabled = false;
            button_false.enabled = false;
            question.text = "Вопросы закончились!";
        }
        else
        {
            if (toggle.isOn)
            {
                question.text = input_field_questions.Keys.First();
            }
            else
            {
                question.text = questions.Keys.First();

            }
        }
        
    }


    public void CompareAnswers(Button button)
    {
        if (questions[question.text] == button)
        {
            response.text = "Krasavchik";
            questions.Remove(question.text);
        }
        else
        {
            response.text = "ur are have stup1d";
        }
    }

    public void TextRewritten()
    {
        if (writing_answer.text == input_field_questions[question.text])
        {
            response.text = "KrasaUvchik";
        }
        
        else
        {
            response.text = "u r gay";
        }
    }
    
}
