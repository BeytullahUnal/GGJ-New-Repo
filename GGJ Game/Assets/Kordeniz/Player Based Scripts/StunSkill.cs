using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunSkill : MonoBehaviour {

	int skillDamage = 10;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 10f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;
	PlayerMovement playerMovement;
	bool isSelected = false;
	AudioSource StunSource;
	public AudioClip Stun;
	void Awake () 
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		playerMovement = GetComponent<PlayerMovement> ();
		StunSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha2) && GCD.isCD==false)
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
			StunSource.clip = Stun;
			StunSource.Play ();
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
