using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RotationControl : MonoBehaviour {



	Vector3 tempVector;




	void Start () {

		tempVector = new Vector3 (Camera.main.transform.position.x, this.transform.position.y, Camera.main.transform.position.z);

	}
	

	void Update () {

		transform.LookAt (tempVector);



	}
}
