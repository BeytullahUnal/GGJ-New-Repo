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
	void Awake () 
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1))
		{
			StunAttack ();
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
