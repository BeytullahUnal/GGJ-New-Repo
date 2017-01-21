using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCD : MonoBehaviour {

	public float CD;
	public float RealCD =7f;
	public bool isCD;

	// Use this for initialization
	void Awake () 
	{
		isCD = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
		KaybettikBeyt2 ();
	}

	public void KaybettikBeyt()
	{
		CD = Time.time + RealCD;
	}

	public void KaybettikBeyt2()
	{
		if (Time.time > CD) 
		{
			isCD = false;
		} 
		else 
		{
			isCD = true;
		}
	}
}

