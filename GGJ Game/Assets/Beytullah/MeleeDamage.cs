using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour {

	public GameObject player;
	HPController hpController;
	int damageAmount = 10;

	float fireRate = 1f;
	float nextFire;

	void Start () {
		hpController = player.GetComponent<HPController> ();
	}
	

	void Update () {
		
	}

	void OnTriggerStay(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			if(Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				hpController.changeHealth (damageAmount);
			}

		}
	}




}
