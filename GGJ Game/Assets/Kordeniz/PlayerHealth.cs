using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int maxhealth = 100;
	int currenthealth;


	// Use this for initialization
	void Awake ()
	{
		currenthealth = maxhealth;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void TakeDamage(int amount)
	{
		currenthealth -= amount;
		//hpbar;
		if (currenthealth <= 0) 
		{
			Dead ();
		}
	}

	public void HealPlayer(int amount)
	{
		currenthealth += amount;
		//hpbar;
		if (currenthealth > maxhealth) 
		{
			currenthealth = maxhealth;
		}
	}

	void Dead()
	{
		//close all behavior codes;
		//dead pose
		//dead sound
	}
}
