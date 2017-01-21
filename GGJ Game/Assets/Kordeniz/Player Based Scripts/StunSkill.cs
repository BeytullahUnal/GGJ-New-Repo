using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunSkill : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 7f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;
	// Use this for initialization

	PlayerMovement playerMovement;
	bool isSelected = false;

	void Awake () 
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		playerMovement = GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha2))
		{
			playerMovement.isCasting = true;
			isSelected = true;
		} 
		if (Input.GetMouseButtonDown(0) && isSelected == true) {
			Debug.Log ("TRITNG");
			StunAttack ();
			playerMovement.isCasting = false;
			isSelected = false;
		}


	}

	public void StunAttack()
	{
		if (Time.time > nextFire && GCD.isCD==false) {
			nextFire = Time.time + fireRate;
			GCD.KaybettikBeyt ();
			Instantiate (shot,shotSpawn.position,shotSpawn.rotation);
		} 
		else 
		{
			//can't fire alert
		}
	}
}
