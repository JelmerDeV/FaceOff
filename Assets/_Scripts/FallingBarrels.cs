using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingBarrels : MonoBehaviour {

	private GameObject barrel1;
	private GameObject barrel2;
	private GameObject ground;
	[SerializeField]private GameObject nextGame;

	private float gravitation;

	private bool falling1;
	private bool falling2;
	private bool ready;

	private bool playerTouchDown1;
	private bool playerTouchUp1;
	private bool playerTouchDown2;
	private bool playerTouchUp2;

	private Vector3 zeroForce;
	private Vector3 fallForce;

	Vector3 barrelPos1;
	Vector3 barrelPos2;
	Vector3 groundPos;

	Vector3 dis1;
	Vector3 dis2;

	private float score1;
	private float score2;

	private string currentPlayer1;
	private string currentPlayer2;

	[SerializeField]private Text winText;

	void Start () {
		nextGame.gameObject.SetActive (false);
		currentPlayer1 = PlayerPrefs.GetString ("CurPlayer1");
		currentPlayer2 = PlayerPrefs.GetString ("CurPlayer2");
		gravitation = 0;

		zeroForce = new Vector3 (0, 0, 0);

		falling1 = true;
		falling2 = true; 
		ready = false;

		barrel1 = GameObject.FindGameObjectWithTag ("barrel1");
		barrel2 = GameObject.FindGameObjectWithTag ("barrel2");
		ground = GameObject.FindGameObjectWithTag ("ground");
	}

	void Update () {



		if (ready && dis1.y > -1) {
			
			falling1 = false;
		}
		if (ready && dis2.y > -1) {

			falling2 = false;
		}
		GetTouchInput ();
		print (playerTouchDown1);
		ReadyUp ();
		
		if(ready){
			if(!falling1 && !falling2){
				CheckPlayerScore ();
				nextGame.SetActive (true);
			}

			MoveBarrels ();
			UpdateGravitation ();
			CheckBarrel1 ();
			CheckBarrel2 ();
		}
	}


	void UpdateGravitation(){
		if(gravitation < 5){
			gravitation += 2 * Time.fixedDeltaTime;
			fallForce = new Vector3 (0, -gravitation, 0);
		}
	}

	void CheckBarrel1(){
		
			if (falling1) {
			barrel1.GetComponent<Rigidbody> ().AddForce(fallForce);
			} else
				barrel1.GetComponent<Rigidbody> ().velocity = zeroForce;


		if (playerTouchUp1 && falling1) {
			falling1 = false;
			score1 = dis1.y * -1;
			Debug.Log ("Player 1: " + score1);

				
		}
	}

	void CheckBarrel2(){

		
			if (falling2) {
			barrel2.GetComponent<Rigidbody> ().AddForce(fallForce);
			} else
				barrel2.GetComponent<Rigidbody> ().velocity = zeroForce;
		
		if (playerTouchUp2 && falling2) {
			    falling2 = false;
				score2 = dis2.y * -1;
			}
	}

	void MoveBarrels(){
		barrelPos1 = barrel1.transform.position;
		barrelPos2 = barrel2.transform.position;
		groundPos = ground.transform.position;

		dis1 = groundPos - barrelPos1;

		dis2 = groundPos - barrelPos2;
	}

	void CheckPlayerScore(){
		if(score1 < 1.2 && score2 < 1.2){
			winText.text = ("Both players crashed!");
		} else if (score1 < 1.2 && score2 > 1.2) {
			winText.text = (currentPlayer2 + " wins! " + "\n" + "\n" + currentPlayer1 + " crashed!");
		} else if (score2 < 1.2 && score1 > 1.2) {
			winText.text = (currentPlayer1 + " wins!" + "\n" + "\n" + currentPlayer2 + " crashed!");
		} else {
			if (score1 < score2) {
				winText.text = (currentPlayer1 + " wins!");
			} else if (score2 < score1) {
				winText.text = (currentPlayer2 + " wins!");
			} else if (score1 == score2) {
				winText.text = ("It's a draw!");
			}
		}
	}

	void ReadyUp(){
		if (playerTouchDown1 && playerTouchDown2) {
			ready = true;
		}
	}

	void GetTouchInput(){
		playerTouchDown1 = PlayerTouch1.touchDown;
		playerTouchUp1 = PlayerTouch1.touchUp;

		playerTouchDown2 = PlayerTouch2.touchDown;
		playerTouchUp2 = PlayerTouch2.touchUp;
	}
		
}
