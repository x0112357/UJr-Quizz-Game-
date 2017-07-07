using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizzLogic : MonoBehaviour
{
    public int nPlayers; //Number of players variable

    public static GameObject player = PlayerManager.currentPlayer;

    //public static Animator test;

    Question currentQuestion;

    public static List<Question> QuestionList = new List<Question>();

    public int n = 0;

    // Use this for initialization
    void Start()
    {
        //test = player.GetComponent<Animator>();
        Debug.Log(CategoryManager.ChoosenCategory.categoryName);
        QuestionList = CategoryManager.ChoosenCategory.Category;
        nextQuestion();

    }

    void choseAnswer(int i)
    {
        Debug.Log(i);
    }

    void nextQuestion()
    {
        if(n > QuestionList.Count - 1)
        {
            //go to Scene for the final
        }
        //pick a question randomly
        //int n = Random.Range(0, QuestionList.Count-1);
        //Debug.Log("random:"+n);
        currentQuestion = QuestionList[n]; //shuffle list before this

        n++;

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
            //test.Play("win");
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