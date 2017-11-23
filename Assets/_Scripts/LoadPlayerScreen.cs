using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadPlayerScreen : MonoBehaviour {

	void OnTouchDown(){
		//Load player input scene
		Application.LoadLevel (1);
	}
}
