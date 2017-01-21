using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFire : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate = 5f;
	private float nextFire;
	int i;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (Time.time > nextFire) 
		{
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}


}
