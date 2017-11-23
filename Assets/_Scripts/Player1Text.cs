using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Text : MonoBehaviour {

	private Text playerText;

	void Start () {
		playerText = gameObject.GetComponent<Text> ();
		playerText.text = PlayerPrefs.GetString("CurPlayer1");
	}
	

}
