using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectL : MonoBehaviour {

	public GameObject objectRotate;
	public AudioSource TurnLSource;
	public AudioClip TurnLClip;
	
	public float rotateSpeed = 50f;
	bool rotateStatus = false;

	public void Rotasi() {

		if (rotateStatus==false){
			rotateStatus = true;
		}
		else {
			rotateStatus = false;
		}
	}

	void Update() {
		if (rotateStatus == true) {
			objectRotate.transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);
			TurnLSource.PlayOneShot (TurnLClip);
		}
	}
}
