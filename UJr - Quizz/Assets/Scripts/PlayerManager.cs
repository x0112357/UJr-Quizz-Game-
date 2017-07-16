using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public GameObject playerPos;
    public List<GameObject> PlayerList;
    public static GameObject currentPlayer;
    public static GameObject currentScene;

    private Animator animator;
    private GameObject aux;

    private int index;
    private bool SceneSelect;

    public void Start()
    {
        index = 0;
        aux = Instantiate(PlayerList[index], playerPos.transform);
        if (currentScene == null)
        {
            currentScene = PlayerList[index];
            SceneSelect = true;
        }
        else if (currentPlayer == null)
        {
            currentPlayer = PlayerList[index];
            SceneSelect = false;
        }
    }
    public void LeftArrow()
    {
        if (index > 0)
        {
            Destroy(aux);
            index--;
            aux = Instantiate(PlayerList[index], playerPos.transform);
            if (SceneSelect)
                currentScene = PlayerList[index];
            else
                currentPlayer = PlayerList[index];
        }
    }
    public void RighArrow()
    {
        if (index < PlayerList.Count - 1)
        {
            Destroy(aux);
            index++;
            aux = Instantiate(PlayerList[index], playerPos.transform);
            if (SceneSelect)
                currentScene = PlayerList[index];
            else
                currentPlayer = PlayerList[index];
        }
    }

    public void SelectPlayer()
    {
        animator = aux.GetComponent<Animator>();
        animator.SetInteger("isSelected", 1);
        StartCoroutine(SelectPlayerStop());
    }
    IEnumerator SelectPlayerStop()
    {
        yield return new WaitForSecondsRealtime(3);
        ButtonManager.AdvanceScene();
    }
}
