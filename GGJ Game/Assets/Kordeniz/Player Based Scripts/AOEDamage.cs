using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOEDamage : MonoBehaviour {

	int skillDamage = 25;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 7f;
	private float nextFire;
	public GlobalCD GCD;
	AudioSource AOESource;
	public AudioClip AOE;
	// Use this for initialization
	void Awake () 
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		AOESource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			

				CastAOE ();

		}
	}

	public void CastAOE()
	{
		if (Time.time > nextFire && GCD.isCD==false) {
			AOESource.clip = AOE;
			AOESource.Play ();
			nextFire = Time.time + fireRate;
			GCD.KaybettikBeyt ();
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		} 
		else 
		{
			//can't fire alert
		}
	}
}
