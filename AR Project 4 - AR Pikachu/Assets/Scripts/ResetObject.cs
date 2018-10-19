using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetObject : MonoBehaviour {

	Vector3 originalpos;
	public Quaternion originalRotationValue;
 	float rotationResetSpeed = 1.0f;
 	public AudioSource FallSource;
    	public AudioClip FallClip;
	void Start () {
		originalpos = transform.localPosition;
		originalRotationValue = transform.localRotation;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider collide) 
	{
		if (collide.gameObject.CompareTag ("THEWALL")) {
			transform.localPosition = originalpos;
         		transform.localRotation = Quaternion.Slerp(transform.rotation, originalRotationValue, Time.time * rotationResetSpeed);
			FallSource.PlayOneShot (FallClip); 
		}
	}
}
