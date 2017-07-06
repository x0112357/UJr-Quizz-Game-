using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour {

    public GameObject playerPos;

	void Start () {
        Instantiate(PlayerManager.currentPlayer, playerPos.transform);
	}
}
