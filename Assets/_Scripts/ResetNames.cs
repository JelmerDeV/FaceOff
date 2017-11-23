using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetNames : MonoBehaviour {

	PlayerInput playerInput;
	[SerializeField]GameObject inputField;

	void Start(){
		playerInput = inputField.GetComponent<PlayerInput> ();

	}

	void OnTouchDown(){
		//Debug.Log ("Reset");
		PlayerPrefs.SetInt("PlayerCount", 0);
		PlayerPrefs.SetString ("player1", "");
		PlayerPrefs.SetString ("player2", "");
		PlayerPrefs.SetString ("player3", "");
		PlayerPrefs.SetString ("player4", "");
		PlayerPrefs.SetString ("player5", "");
		PlayerPrefs.SetString ("player6", "");

		playerInput.playerText.text = " ";
	}
}
