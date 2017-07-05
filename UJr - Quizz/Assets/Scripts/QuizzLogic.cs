using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizzLogic : MonoBehaviour
{

    public int nPlayers; //Number of players variable

    public LinkedList<Question> QuestionList = new LinkedList<Question>(); //start by having a list of objects (question objects)

    public string[] QuestionsArray;
    public string[] CorrectAnswer;
    public string[] PossibleAnswers;

    UnityEngine.UI.Button button1;
    UnityEngine.UI.Button button2;
    UnityEngine.UI.Button button3;
    UnityEngine.UI.Button button4;

    Question currentQuestion;

    // Use this for initialization
    void Start()
    {

        button1 = GameObject.Find("B1").GetComponent<UnityEngine.UI.Button>();
        button2 = GameObject.Find("B2").GetComponent<UnityEngine.UI.Button>();
        button3 = GameObject.Find("B3").GetComponent<UnityEngine.UI.Button>();
        button4 = GameObject.Find("B4").GetComponent<UnityEngine.UI.Button>();

        button1.onClick.AddListener(() => choseAnswer(1));
        button2.onClick.AddListener(() => choseAnswer(2));
        button3.onClick.AddListener(() => choseAnswer(3));
        button4.onClick.AddListener(() => choseAnswer(4));

        for (int i = 0; i < QuestionsArray.Length; i++)
        {
            string[] pAnswers = new string[4];
            for(int j = 0; j < 4; j++)
            {
                pAnswers[j] = PossibleAnswers[i + j]; 
            }

            //construct the question
            Question cQuestion = new Question(QuestionsArray[i],CorrectAnswer[i],pAnswers);

            Debug.Log(cQuestion.question + " - " + cQuestion.correctAnsewer);

            //add the element to the list
            QuestionList.AddLast(cQuestion);
        }

        nextQuestion();

    }

    void choseAnswer(int i)
    {
        Debug.Log(i);
    }

    void nextQuestion()
    {
        //pick a question randomly
        int n = Random.Range(0, QuestionList.Count);
        Debug.Log("random:"+n);
        currentQuestion = getElement(QuestionList, n);

        GameObject.Find("QuestionText").GetComponent<UnityEngine.UI.Text>().text = currentQuestion.question;

        GameObject.Find("A1").GetComponent<UnityEngine.UI.Text>().text = currentQuestion.PossibleAnswers[0];
        GameObject.Find("A2").GetComponent<UnityEngine.UI.Text>().text = currentQuestion.PossibleAnswers[1];
        GameObject.Find("A3").GetComponent<UnityEngine.UI.Text>().text = currentQuestion.PossibleAnswers[2];
        GameObject.Find("A4").GetComponent<UnityEngine.UI.Text>().text = currentQuestion.PossibleAnswers[3];

    }

    // Update is called once per frame
    void Update()
    {

    }

    Question getElement(LinkedList<Question> start, int index) //function to return a specific element from the list (I coudldn't find a get(index))
    {
        LinkedListNode<Question> cursor = start.First;
        int counter = 0;
        while (counter < index)
        {
            cursor = cursor.Next;
            counter++;
        }
        Debug.Log(counter);
        return cursor.Value;
    }
}

public class Question
{
    //each question will have a list of possible answers, the correct answer and the question
    public string question;
    public string[] PossibleAnswers = new string[4];
    public string correctAnsewer;

    public Question(string q, string cAnswer, string[] pAnswers) //Constructor for the Question data structure
    {
        this.question = q;
        this.correctAnsewer = cAnswer;
        for(int i = 0; i < pAnswers.Length; i++)
        {
            this.PossibleAnswers[i] = pAnswers[i];
        }
    }

}