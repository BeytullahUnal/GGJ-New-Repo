using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind1 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement1 enemyEchoMovement1;
	GameObject target;

	void Start () {
		enemyEchoMovement1 = Origin.GetComponent<EnemyEchoMovement1> ();

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
			EnemyEchoMovement1.isOnTarget = true;
			EnemyEchoMovement1.targetPlayer = target;
		}
	}
}
