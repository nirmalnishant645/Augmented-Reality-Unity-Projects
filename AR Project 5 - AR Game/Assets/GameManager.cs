using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public int currentPokeball;
	public	Text pokeballText;	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddPokeball(int pokeballToAdd)
	{
		currentPokeball += pokeballToAdd;
		pokeballText.text = "Pokeball: " + currentPokeball;
	}
}
