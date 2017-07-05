using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizLogic : MonoBehaviour {

    public int nPlayers; //Number of players variable

    public LinkedList<Question> QuestionList; //start by having a list of objects (question objects)

    public string[] QuestionsArray = new string[10];
    public string[] t;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < QuestionsArray.Length; i++)
        {
            Question cQuestion = new Question();
            //construct the question
            //add the element to the list
            QuestionList.AddLast(cQuestion);
        }

	}
	
    void nextQuestion()
    {
        //pick a question randomly
        int n = Random.Range(0, QuestionList.Count);
        Question currentQuestion = getElement(QuestionList, n);

        Debug.logger.Log(currentQuestion.question);
    }

	// Update is called once per frame
	void Update () {
		
	}

    Question getElement(LinkedList<Question> start, int index) //function to return a specific element from the list (I coudldn't find a get(index))
    {
        LinkedListNode<Question> cursor = start.First;
        int counter = 0; 
        while(counter <= index)
        {
            cursor = cursor.Next;
        }
        return cursor.Value;
    }
}

public class Question
{
    //each question will have a list of possible answers, the correct answer and the question
    public string question; 
    public LinkedList<string> PossibleAnswers = new LinkedList<string>();
    public string correctAnsewer;

    public Question() //Constructor for the Question data structure
    {

    }

}
