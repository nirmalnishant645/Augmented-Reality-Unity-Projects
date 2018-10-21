using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PikachuAnimation : MonoBehaviour {

	private Animator Anim;
	

	// Use this for initialization
	void Start () {

		Anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	public void AnimStop() {
		Anim.Play("Stop", -1, 0f);
		Anim.speed = 1f;
	}	
	
	public void AnimForward() {

		Anim.Play("Forward", -1, 0f);
		Anim.speed = 1f;
	}

	public void AnimLeft() {
		Anim.Play("Left", -1, 0f);
		Anim.speed = 1f;
	}

	public void AnimRight() {
		Anim.Play("Right", -1, 0f);
		Anim.speed = 1f;
	}

}
