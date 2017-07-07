using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject scenePos;
    public GameObject playerPos;
    public static GameObject cPlayer;
    void Start()
    {
        Instantiate(PlayerManager.currentScene, scenePos.transform);
        if (PlayerManager.currentPlayer != null)
            cPlayer = Instantiate(PlayerManager.currentPlayer, playerPos.transform);
    }
}
