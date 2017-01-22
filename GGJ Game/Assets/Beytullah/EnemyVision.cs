using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVision : MonoBehaviour {


	public GameObject Enemy;
	GameObject targetObject;

	EnemyMovement enemyMovement;
	//EnemyCombat enemyCombat;

	void Start () {
		enemyMovement = Enemy.GetComponent<EnemyMovement> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Player")
		{
			Debug.Log ("Player Tagged Found");
			targetObject = other.gameObject;
			enemyMovement.DisablePatrol ();
			enemyMovement.MoveToMelee (targetObject);
		}
	}

	void OnTriggerExit(Collider other1)
	{
		
	}
}
