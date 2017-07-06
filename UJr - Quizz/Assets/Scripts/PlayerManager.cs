using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public GameObject playerPos;
    public List<GameObject> PlayerList;

    private int index;

    public void Start()
    {
        index = 0;
        Player.currentPlayer = Instantiate(PlayerList[index], playerPos.transform);
       
    }
    public void LeftArrow()
    {
        if(index > 0)
        {
            Destroy(Player.currentPlayer);
            index--;
            Player.currentPlayer = Instantiate(PlayerList[index], playerPos.transform);
        }
    }
    public void RighArrow()
    {
        if(index < PlayerList.Count - 1)
        {
            Destroy(Player.currentPlayer);
            index++;
            Player.currentPlayer = Instantiate(PlayerList[index], playerPos.transform);
        }
    }
}
public class Player
{
    public static GameObject currentPlayer;
}
