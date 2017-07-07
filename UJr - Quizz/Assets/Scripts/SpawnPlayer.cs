using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject scenePos;
    public GameObject playerPos;

    void Start()
    {
        Instantiate(PlayerManager.currentScene, scenePos.transform);
        if (PlayerManager.currentPlayer != null)
            Instantiate(PlayerManager.currentPlayer, playerPos.transform);
    }
}
