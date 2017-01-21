using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine (Scale ());
	}

	IEnumerator Scale() 
	{

		for (int i = 0; i < 5; i++) 
		{
			


		}
		gameObject.transform.localScale += new Vector3(0.09f,0.09f,0.09f) ;
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);

	}
}
