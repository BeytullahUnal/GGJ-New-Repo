using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement enemyEchoMovement;
	GameObject target;

	void Start () {
		enemyEchoMovement = Origin.GetComponent<EnemyEchoMovement> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			Debug.Log ("Echoed Target");
			target = other.gameObject;
			EnemyEchoMovement.isOnTarget = true;
			EnemyEchoMovement.targetPlayer = target;
		}
	}
}
