using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMinigame : MonoBehaviour {

	void OnTouchDown(){
		//Choose random minigame (2 ---> total minigames + 1)

		if(PlayerPrefs.GetInt("PlayerCount") >= 2)
		Application.LoadLevel(Random.Range(3, 3));
		//Application.LoadLevel(2);
	}
}
