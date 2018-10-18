using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {

	// Use this for initialization
	public float xvalue, yvalue, zvalue;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate (new Vector3 (xvalue, yvalue, zvalue) * Time.deltaTime);
	}
}
