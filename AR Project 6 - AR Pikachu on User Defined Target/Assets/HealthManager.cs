using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;

	public PikachuAnimation thePlayer;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;	
		
		thePlayer = FindObjectOfType<PikachuAnimation>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HurtPlayer(int damage)
	{
		currentHealth -= damage;
	
	}

	public void HealPlayer(int healAmount)
	{
		currentHealth += healAmount;
		
		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	}
}
