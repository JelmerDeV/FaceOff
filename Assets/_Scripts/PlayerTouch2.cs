using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouch2 : MonoBehaviour {

	static public bool touchDown = false;
	static public bool touchUp = false;


	void Update(){
		#if UNITY_EDITOR
		if(Input.GetKeyDown("right")){

			touchUp = false;
			touchDown = true;

		}else if(Input.GetKeyUp("right")){
			touchDown = false;
			touchUp = true;
		}



		#endif
	}


	void OnTouchDown(){
		touchUp = false;
		touchDown = true;
	}

	void OnTouchStay(){
		touchDown = true;
	}

	void OnTouchExit(){
		touchDown = false;
		touchUp = true;
	}

	void OnTouchUp(){
		touchDown = false;
		touchUp = true;
	}

}
