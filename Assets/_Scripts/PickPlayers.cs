using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickPlayers : MonoBehaviour {
	private string Plr1;
	private string Plr2;
	private int PlrIndex1;
	private int PlrIndex2;

	[SerializeField]private Text playerText;

	void Start () {
		PlayerPrefs.SetString ("CurPlayer1", "");
		PlayerPrefs.SetString ("CurPlayer2", "");
		
		PickIndex ();
	}

	void Update(){
		if (PlrIndex2 == PlrIndex1) {
			PlrIndex1 = Random.Range (1, PlayerPrefs.GetInt ("PlayerCount") + 1);
			PlrIndex2 = Random.Range (1, PlayerPrefs.GetInt ("PlayerCount") + 1);
		} else {
			RandPick1 ();
			RandPick2 ();
			SetPlayerText ();
		}
			
	}
	
	void RandPick1(){
		

		switch (PlrIndex1)
		{
		case 1:
			Plr1 = PlayerPrefs.GetString ("player1");
			break;
		case 2:
			Plr1 = PlayerPrefs.GetString ("player2");
			break;
		case 3:
			Plr1 = PlayerPrefs.GetString ("player3");
			break;
		case 4:
			Plr1 = PlayerPrefs.GetString ("player4");
			break;
		case 5:
			Plr1 = PlayerPrefs.GetString ("player5");
			break;
		case 6:
			Plr1 = PlayerPrefs.GetString ("player6");
			break;
			}

		PlayerPrefs.SetString ("CurPlayer1", Plr1);
		Debug.Log (PlayerPrefs.GetString("CurPlayer1"));
	}

	void RandPick2(){

		switch (PlrIndex2)
		{
		case 1:
			Plr2 = PlayerPrefs.GetString ("player1");
			break;
		case 2:
			Plr2 = PlayerPrefs.GetString ("player2");
			break;
		case 3:
			Plr2 = PlayerPrefs.GetString ("player3");
			break;
		case 4:
			Plr2 = PlayerPrefs.GetString ("player4");
			break;
		case 5:
			Plr2 = PlayerPrefs.GetString ("player5");
			break;
		case 6:
			Plr2 = PlayerPrefs.GetString ("player6");
			break;
		}


		PlayerPrefs.SetString ("CurPlayer2", Plr2);
		Debug.Log (PlayerPrefs.GetString("CurPlayer2"));
	}

	void PickIndex(){
		PlrIndex1 = Random.Range (1, PlayerPrefs.GetInt ("PlayerCount") + 1);
		PlrIndex2 = Random.Range (1, PlayerPrefs.GetInt ("PlayerCount") + 1);
	}

	private void SetPlayerText (){
		playerText.text = Plr1 + " VS " + Plr2;
	}
}
