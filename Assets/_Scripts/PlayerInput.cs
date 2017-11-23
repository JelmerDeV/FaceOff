using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerInput : MonoBehaviour {
	public Text playerText;
	private int playerCnt;

	void Start ()
	{
		
		playerCnt = 0;
		PlayerPrefs.SetInt ("PlayerCount", playerCnt);

		var input = gameObject.GetComponent<InputField>();
		var subE= new InputField.SubmitEvent();
		subE.AddListener(SubmitName);
		input.onEndEdit = subE;
		input.characterLimit = 8;

		//or simply use the line below, 
		//input.onEndEdit.AddListener(SubmitName);  // This also works
	}

	void Update(){
		Debug.Log (PlayerPrefs.GetInt ("PlayerCount", playerCnt));
		if (PlayerPrefs.GetString ("player1") == "") {
			playerCnt = 0;
		}
	}

	private void SubmitName(string arg0)
	{
		
		//Debug.Log(arg0);
		if (playerCnt == 0) {
			
			PlayerPrefs.SetString ("player1", arg0);
			playerText.text = "Player 1: " + PlayerPrefs.GetString("player1");
			playerCnt++;
		} else if (playerCnt == 1) {
			
			if (arg0 != PlayerPrefs.GetString ("player1")) {
				PlayerPrefs.SetString ("player2", arg0);
				playerText.text = "Player 1: " + PlayerPrefs.GetString ("player1") +
				"\nPlayer 2: " + PlayerPrefs.GetString ("player2");
				playerCnt++;
			}
		} else if (playerCnt == 2) {

			if (arg0 != PlayerPrefs.GetString ("player1") && arg0 != PlayerPrefs.GetString ("player2")) {
				PlayerPrefs.SetString ("player3", arg0);
				playerText.text = "Player 1: " + PlayerPrefs.GetString ("player1") +
				"\nPlayer 2: " + PlayerPrefs.GetString ("player2") +
				"\nPlayer 3: " + PlayerPrefs.GetString ("player3");
				playerCnt++;
			}
		} else if (playerCnt == 3) {

			if (arg0 != PlayerPrefs.GetString ("player1") && arg0 != PlayerPrefs.GetString ("player2") && arg0 != PlayerPrefs.GetString ("player3")) {
				PlayerPrefs.SetString ("player4", arg0);
				playerText.text = "Player 1: " + PlayerPrefs.GetString ("player1") +
				"\nPlayer 2: " + PlayerPrefs.GetString ("player2") +
				"\nPlayer 3: " + PlayerPrefs.GetString ("player3") +
				"\nPlayer 4: " + PlayerPrefs.GetString ("player4");
				playerCnt++;
			}
		} else if (playerCnt == 4) {

			if (arg0 != PlayerPrefs.GetString ("player1") && arg0 != PlayerPrefs.GetString ("player2") && arg0 != PlayerPrefs.GetString ("player3") && arg0 != PlayerPrefs.GetString ("player4")) {
				PlayerPrefs.SetString ("player5", arg0);
				playerText.text = "Player 1: " + PlayerPrefs.GetString ("player1") +
				"\nPlayer 2: " + PlayerPrefs.GetString ("player2") +
				"\nPlayer 3: " + PlayerPrefs.GetString ("player3") +
				"\nPlayer 4: " + PlayerPrefs.GetString ("player4") +
				"\nPlayer 5: " + PlayerPrefs.GetString ("player5");
				playerCnt++;
			}
		} else if (playerCnt == 5) {

			if (arg0 != PlayerPrefs.GetString ("player1") && arg0 != PlayerPrefs.GetString ("player2") && arg0 != PlayerPrefs.GetString ("player3") && arg0 != PlayerPrefs.GetString ("player4") && arg0 != PlayerPrefs.GetString ("player5")) {
				PlayerPrefs.SetString ("player6", arg0);
				playerText.text = "Player 1: " + PlayerPrefs.GetString ("player1") +
				"\nPlayer 2: " + PlayerPrefs.GetString ("player2") +
				"\nPlayer 3: " + PlayerPrefs.GetString ("player3") +
				"\nPlayer 4: " + PlayerPrefs.GetString ("player4") +
				"\nPlayer 5: " + PlayerPrefs.GetString ("player5") +
				"\nPlayer 6: " + PlayerPrefs.GetString ("player6");
				playerCnt++;
			}
		} else 
			Debug.Log ("Party Full!");




		PlayerPrefs.SetInt ("PlayerCount", playerCnt);
		/*Debug.Log ("speler 1: " + PlayerPrefs.GetString("player1"));
		Debug.Log ("speler 2: " + PlayerPrefs.GetString("player2"));
		Debug.Log ("speler 3: " + PlayerPrefs.GetString("player3"));
		Debug.Log ("speler 4: " + PlayerPrefs.GetString("player4"));
		Debug.Log ("speler 5: " + PlayerPrefs.GetString("player5"));
		Debug.Log ("speler 6: " + PlayerPrefs.GetString("player6"));
		Debug.Log (playerCnt);*/
	}
		
}
