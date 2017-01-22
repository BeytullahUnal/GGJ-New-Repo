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

	int skillDamage = 15;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 7f;
	private float nextFire;
	public int looper;
	public GlobalCD GCD;

	PlayerMovement playerMovement;
	bool isSelected = false;

	public Animation soloAnim;
	public GameObject soloAnimObj;
	public GameObject walkAnimObj;
	bool isAnimating = false;
	public AudioClip Fire1;
	public AudioClip Fire2;
	AudioSource AS;
	void Awake()
	{
		GCD = gameObject.GetComponent<GlobalCD> ();
		playerMovement = GetComponent<PlayerMovement> ();
		AS = GetComponent<AudioSource> ();
	}

	void Update ()
	{
		if (isAnimating == true) {
			soloAnimObj.SetActive (true);
			soloAnim.Play ();
		}
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
			int index = Random.Range (0, 1);
			if(index==0)
			{
				AS.clip=Fire1;
			}
			if(index==1) 
			{
				AS.clip=Fire2;
			}
			AS.Play ();
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
		walkAnimObj.SetActive (false);
		isAnimating = true;
		for (int i = 0; i < 4; i++) 
		{
			Instantiate (shot,shotSpawn.position,shotSpawn.rotation);
			yield return new WaitForSeconds (1f);
		}
		isAnimating = false;
		soloAnimObj.SetActive (false);
		walkAnimObj.SetActive (true);
		playerMovement.isCasting = false;
		isSelected = false;
	}
}
