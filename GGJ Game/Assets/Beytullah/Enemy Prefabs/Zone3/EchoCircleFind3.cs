using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind3 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement3 enemyEchoMovement3;
	GameObject target;

	void Start () {
		enemyEchoMovement3 = Origin.GetComponent<EnemyEchoMovement3> ();

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
			EnemyEchoMovement3.isOnTarget = true;
			EnemyEchoMovement3.targetPlayer = target;
		}
	}
}
