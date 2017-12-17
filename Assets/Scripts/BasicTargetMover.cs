using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargetMover : MonoBehaviour {
	public bool doSpin = true;
	public float spinSpeed = 180.0f;
	public bool doMove = false;
	public float motionMagnitude = 0.1f;
	// Update is called once per frame
	void Update () {
		if (doSpin) {
			gameObject.transform.Rotate (Vector3.up * spinSpeed * Time.deltaTime);
		}
		if (doMove) {
			gameObject.transform.Translate (Vector3.up * Mathf.Cos (Time.timeSinceLevelLoad) * motionMagnitude);
		}
	}
}
