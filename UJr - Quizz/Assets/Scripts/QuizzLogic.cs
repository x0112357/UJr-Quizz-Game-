using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizzLogic : MonoBehaviour
{
    public int nPlayers; //Number of players variable

    Button button1;
    Button button2;
    Button button3;
    Button button4;

    Question currentQuestion;

    public List<Question> QuestionList;

    // Use this for initialization
    void Start()
    {        
        button1 = GameObject.Find("B1").GetComponent<Button>();
        button2 = GameObject.Find("B2").GetComponent<Button>();
        button3 = GameObject.Find("B3").GetComponent<Button>();
        button4 = GameObject.Find("B4").GetComponent<Button>();

        button1.onClick.AddListener(() => choseAnswer(1));
        button2.onClick.AddListener(() => choseAnswer(2));
        button3.onClick.AddListener(() => choseAnswer(3));
        button4.onClick.AddListener(() => choseAnswer(4));

        nextQuestion();

    }

    void choseAnswer(int i)
    {
        Debug.Log(i);
    }

    void nextQuestion()
    {
        //pick a question randomly
        int n = Random.Range(0, QuestionList.Count-1);
        //Debug.Log("random:"+n);
        currentQuestion = QuestionList[n];

        GameObject.Find("QuestionText").GetComponent<Text>().text = currentQuestion.question;

        int cPlace = Random.Range(0,3)+1;

        Debug.Log("A"+cPlace+"CA: "+currentQuestion.correctAnsewer);

        string cPlaceString = "A"+cPlace.ToString();

        Debug.Log(cPlaceString);

        GameObject.Find(cPlaceString).GetComponent<Text>().text = currentQuestion.correctAnsewer;

        int c = 0;


        for (int i = 0; i < 4; i++)
        {
            if (i != (cPlace-1))
            {
                GameObject.Find("A"+(i + 1)).GetComponent<Text>().text = currentQuestion.PossibleAnswers[c];
                c++;
            }
        }

    }

    public void SelectAnswer(Text text)
    {
        if (text.text.Equals(currentQuestion.correctAnsewer))
        {
            //scores points.
            nextQuestion();
        }
        else
        {
            //does not score points.
            nextQuestion();
        }
    }
}

[System.Serializable]
public class Question
{
    //each question will have a list of possible answers, the correct answer and the question
    public string question;
    public string[] PossibleAnswers = new string[3];
    public string correctAnsewer;
}