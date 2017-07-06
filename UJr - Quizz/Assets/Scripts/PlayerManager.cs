using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject playerPos;
    public List<GameObject> PlayerList;
    public static GameObject currentPlayer;

    private GameObject aux;

    private int index;

    public void Start()
    {
        index = 0;
        aux = Instantiate(PlayerList[index], playerPos.transform);
        currentPlayer = PlayerList[index];
    }
    public void LeftArrow()
    {
        if(index > 0)
        {
            Destroy(aux);
            index--;
            aux = Instantiate(PlayerList[index], playerPos.transform);
            currentPlayer = PlayerList[index];
        }
    }
    public void RighArrow()
    {
        if(index < PlayerList.Count - 1)
        {
            Destroy(aux);
            index++;
            aux = Instantiate(PlayerList[index], playerPos.transform);
            currentPlayer = PlayerList[index];
        }
    }
}
