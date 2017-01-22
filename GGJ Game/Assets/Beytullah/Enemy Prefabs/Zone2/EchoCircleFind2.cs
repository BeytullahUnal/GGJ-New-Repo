using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind2 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement2 enemyEchoMovement2;
	GameObject target;

	void Start () {
		enemyEchoMovement2 = Origin.GetComponent<EnemyEchoMovement2> ();

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
			EnemyEchoMovement2.isOnTarget = true;
			EnemyEchoMovement2.targetPlayer = target;
		}
	}
}
