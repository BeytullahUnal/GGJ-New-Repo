using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMover : MonoBehaviour
{

	public float speed;
	Rigidbody rb;
	void Start ()
	{
		rb = this.GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}
		

}
