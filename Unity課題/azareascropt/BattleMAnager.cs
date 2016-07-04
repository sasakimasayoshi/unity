using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class BattleMAnager : MonoBehaviour {

	int battleStatus;

	const int BATTLE_START = 0;
	const int BATTLE_PLAY = 1;
	const int BATTLE_END = 2;

	// Use this for initialization
	void Start () {
		battleStatus = BATTLE_START;
	}
	
	// Update is called once per frame
	void Update () {
		switch (battleStatus) {
		case BATTLE_START:
			break;
		case BATTLE_PLAY:
			break;
		case BATTLE_END:
			break;
		default:
			break;
		}
	}
}
