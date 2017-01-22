using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int maxhealth = 100;
	public int currenthealth;
	public Image HP1;
	public Image HP2;
	public Image HP3;

	// Use this for initialization
	void Awake ()
	{
		currenthealth = maxhealth;
	}
	
	// Update is called once per frame
	void Update () 
	{
		 HealthHandler();
	}

	public void TakeDamage(int amount)
	{
		currenthealth -= amount;

		if (currenthealth <= 0) 
		{
			Dead ();
		}
	}

	public void HealPlayer(int amount)
	{
		currenthealth += amount;

		if (currenthealth > maxhealth) 
		{
			currenthealth = maxhealth;
		}
	}

	void HealthHandler()
	{
		if (currenthealth <= 75 && currenthealth >= 40) 
		{
			HP1.color = new Color32(255, 255, 255, 0);
			HP2.color = new Color32(255, 255, 255, 255);
			HP3.color = new Color32(255, 255, 255, 0);
			Debug.Log ("AĞAĞAĞAA");
		}

		if (currenthealth < 40) 
		{
			HP1.color = new Color32(255, 255, 255, 0);
			HP2.color = new Color32(255, 255, 255, 0);
			HP3.color = new Color32(255, 255, 255, 255);
		} 

		if(currenthealth>75) 
		{
			HP1.color = new Color32 (255, 255, 255, 255);
			HP2.color = new Color32(255, 255, 255, 0);
			HP3.color = new Color32(255, 255, 255, 0);
		}


	}

	void Dead()
	{
		//close all behavior codes;
		//dead pose
		//dead sound
	}
}
