using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPlayerPicker : MonoBehaviour {

	void OnTouchDown(){
		Application.LoadLevel (2);
	}
}
