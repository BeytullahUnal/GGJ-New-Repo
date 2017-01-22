using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind6 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement6 enemyEchoMovement6;
	GameObject target;

	void Start () {
		enemyEchoMovement6 = Origin.GetComponent<EnemyEchoMovement6> ();

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
			EnemyEchoMovement6.isOnTarget = true;
			EnemyEchoMovement6.targetPlayer = target;
		}
	}
}
