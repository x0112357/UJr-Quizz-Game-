using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public GameObject GameScreen;
    public GameObject PauseScreen;

    bool isPaused;

    public void Awake()
    {
        isPaused = false;
    }

    public void Update()
    {
        if(Input.GetAxis("Cancel") != 0)
        {
            if (PauseScreen.activeSelf == true)
                Application.Quit();
            PauseScreen.SetActive(true);
            GameScreen.SetActive(false);
            isPaused = true;
        }
    }

    public static void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void AdvanceSceneNonStatic()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void TogglePause()
    {
        isPaused = !isPaused;
        GameScreen.SetActive(!GameScreen.activeSelf);
        PauseScreen.SetActive(!PauseScreen.activeSelf);
    }
    public void ChooseTheme()
    {
        SceneManager.LoadScene(0);
    }
    public void ChooseChar()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
