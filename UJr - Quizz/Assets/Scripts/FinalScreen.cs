using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject.Find("Score").GetComponent<Text>().text = "Your Score: "+QuizzLogic.score;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void tryAgain()
    {
        SceneManager.LoadScene(0);
    }
}
