using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunEffect : MonoBehaviour {



	void Start () {
		
	}
	

	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Enemy")
		{
			Debug.Log ("Collision Detected");
			EnemyMovement enemyMovement = other.gameObject.GetComponent<EnemyMovement> ();
			enemyMovement.InitiateStun ();
		}
		if(other.transform.tag == "EchoEnemy")
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement enemyEchoMovement = other.gameObject.GetComponent<EnemyEchoMovement> ();
			enemyEchoMovement.InitiateStun ();
		}
	}


}
