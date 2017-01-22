using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind5 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement5 enemyEchoMovement5;
	GameObject target;

	void Start () {
		enemyEchoMovement5 = Origin.GetComponent<EnemyEchoMovement5> ();

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
			EnemyEchoMovement5.isOnTarget = true;
			EnemyEchoMovement5.targetPlayer = target;
		}
	}
}
