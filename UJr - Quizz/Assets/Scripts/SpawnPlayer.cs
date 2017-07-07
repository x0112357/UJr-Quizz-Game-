using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {

    public GameObject playerPos;

    public static GameObject cPlayer;

	void Start () {
        cPlayer = Instantiate(PlayerManager.currentPlayer, playerPos.transform);
	}
}
