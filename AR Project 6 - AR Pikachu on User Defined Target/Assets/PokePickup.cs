using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokePickup : MonoBehaviour {

	public int value;
	public AudioSource audioSource;
	public AudioClip audioClip;

	public GameObject pickupEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			FindObjectOfType<GameManager>().AddPokeball(value);
			Instantiate(pickupEffect, transform.position, transform.rotation);
			Destroy(gameObject);
			audioSource.PlayOneShot(audioClip);
		}
	}
}
