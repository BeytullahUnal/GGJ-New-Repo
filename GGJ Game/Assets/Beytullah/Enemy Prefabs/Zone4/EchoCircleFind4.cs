using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind4 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement4 enemyEchoMovement4;
	GameObject target;

	void Start () {
		enemyEchoMovement4 = Origin.GetComponent<EnemyEchoMovement4> ();

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
			EnemyEchoMovement4.isOnTarget = true;
			EnemyEchoMovement4.targetPlayer = target;
		}
	}
}
