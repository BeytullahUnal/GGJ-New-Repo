using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUIHandle : MonoBehaviour {

	public PlayerHealth PH;
	public Image HP1;
	public Image HP2;
	public Image HP3;
	// Use this for initialization
	void Awake ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void HealthHandler()
	{
		if (PH.currenthealth <= 75 && PH.currenthealth >= 40) 
		{
			HP1.color = new Color32(255, 255, 255, 0);
			HP2.color = new Color32(255, 255, 255, 255);
		}

		if (PH.currenthealth < 40) 
		{
			HP2.color = new Color32(255, 255, 255, 0);
			HP3.color = new Color32(255, 255, 255, 255);
		} 

		else 
		{
			HP2.color = new Color32(255, 255, 255, 0);
			HP3.color = new Color32(255, 255, 255, 0);
		}


	}
}
