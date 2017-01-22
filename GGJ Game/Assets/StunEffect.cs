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
		if(other.transform.name.Contains("Echo1"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement1 enemyEchoMovement1 = other.gameObject.GetComponent<EnemyEchoMovement1> ();
			enemyEchoMovement1.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo2"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement2 enemyEchoMovement2 = other.gameObject.GetComponent<EnemyEchoMovement2> ();
			enemyEchoMovement2.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo3"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement3 enemyEchoMovement3 = other.gameObject.GetComponent<EnemyEchoMovement3> ();
			enemyEchoMovement3.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo4"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement4 enemyEchoMovement4 = other.gameObject.GetComponent<EnemyEchoMovement4> ();
			enemyEchoMovement4.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo5"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement5 enemyEchoMovement5 = other.gameObject.GetComponent<EnemyEchoMovement5> ();
			enemyEchoMovement5.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo6"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement6 enemyEchoMovement6 = other.gameObject.GetComponent<EnemyEchoMovement6> ();
			enemyEchoMovement6.InitiateStun ();
		}
		if(other.transform.name.Contains("Echo7"))
		{
			Debug.Log ("Collision Detected");
			EnemyEchoMovement7 enemyEchoMovement7 = other.gameObject.GetComponent<EnemyEchoMovement7> ();
			enemyEchoMovement7.InitiateStun ();
		}
	}


}
