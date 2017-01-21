using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}
	
public class PlayerShooting : MonoBehaviour
{

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 7f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;


	void Awake()
	{
		GCD = gameObject.GetComponent<GlobalCD> ();

	}

	void Update ()
	{
		if (Input.GetButton ("Fire1"))
		{
			DamageAttack ();
		} 


	}

	public void DamageAttack()
	{
		if (Time.time > nextFire && GCD.isCD==false) {
			nextFire = Time.time + fireRate;
			GCD.KaybettikBeyt ();
			StartCoroutine (Shoot ());
		} 
		else 
		{
			//can't fire alert
		}
	}

	IEnumerator Shoot() 
	{

		for (int i = 0; i < 5; i++) 
		{
			Instantiate (shot,shotSpawn.position,shotSpawn.rotation);
			yield return new WaitForSeconds (1f);

		}



	}
}
