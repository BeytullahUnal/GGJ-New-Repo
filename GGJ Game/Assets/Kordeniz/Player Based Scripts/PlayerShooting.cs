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

	int skillDamage = 10;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 7f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;

	PlayerMovement playerMovement;
	bool isSelected = false;

	void Awake()
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		playerMovement = GetComponent<PlayerMovement> ();

	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Alpha1) && GCD.isCD==false) {
			Debug.Log (GCD.isCD);
			playerMovement.isCasting = true;
			isSelected = true;
		}
		if (Input.GetMouseButtonDown(0) && isSelected == true) {
			Debug.Log ("TRITNG");
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
		playerMovement.isCasting = false;
		isSelected = false;
	}
}
