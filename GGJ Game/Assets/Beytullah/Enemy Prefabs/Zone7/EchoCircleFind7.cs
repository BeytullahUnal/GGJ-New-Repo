using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoCircleFind7 : MonoBehaviour {

	public GameObject Origin;
	EnemyEchoMovement7 enemyEchoMovement7;
	GameObject target;

	void Start () {
		enemyEchoMovement7 = Origin.GetComponent<EnemyEchoMovement7> ();

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
			EnemyEchoMovement7.isOnTarget = true;
			EnemyEchoMovement7.targetPlayer = target;
		}
	}
}
