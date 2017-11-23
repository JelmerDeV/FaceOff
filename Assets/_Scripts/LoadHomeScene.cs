using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHomeScene : MonoBehaviour {

	void OnTouchDown(){
		Application.LoadLevel (0);
	}
}
