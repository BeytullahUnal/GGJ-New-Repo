using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunSkill : MonoBehaviour {

	int skillDamage = 10;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 20f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;
	PlayerMovement playerMovement;
	bool isSelected = false;
	AudioClip Stun;

	AudioSource AU;

	void Awake () 
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		playerMovement = GetComponent<PlayerMovement> ();
		AU = gameObject.GetComponent<AudioSource> ();
		AU.clip = Stun;
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
			AU.Play ();
			Instantiate (shot,shotSpawn.position,shotSpawn.rotation);
		} 
		else 
		{
			//can't fire alert
		}
	}
}
