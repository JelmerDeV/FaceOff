using UnityEngine;
using System.Collections;

public class CloudMovement : MonoBehaviour {
	float leftConstraint = Screen.width;
	float rightConstraint = Screen.width;
	float bottomConstraint = Screen.height;
	float topConstraint = Screen.height;

	private float windSpeed;
	float buffer = 1.5f;
	Camera cam;
	float distanceZ;

	void Start() {
		windSpeed = Random.Range (0.005f, 0.015f);

		cam = Camera.main;
		distanceZ = Mathf.Abs(cam.transform.position.z + transform.position.z);

		leftConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).x;
		rightConstraint = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, distanceZ)).x;
		bottomConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, distanceZ)).y;
		topConstraint = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, distanceZ)).y;
	}

	void FixedUpdate() {
		MoveObject ();

		if (transform.position.x < leftConstraint - buffer) {
			transform.position = new Vector3(rightConstraint + buffer, transform.position.y, transform.position.z);
		}
		if (transform.position.x > rightConstraint + buffer) {
			transform.position = new Vector3(leftConstraint - buffer, transform.position.y, transform.position.z);
		}
		if (transform.position.y < bottomConstraint - buffer) {
			transform.position = new Vector3(transform.position.x, topConstraint + buffer, transform.position.z);
		}
		if (transform.position.y > topConstraint + buffer) {
			transform.position = new Vector3(transform.position.x, bottomConstraint - buffer, transform.position.z);
		}
	}

	void MoveObject(){
		transform.Translate (windSpeed,0,0);
	}
}