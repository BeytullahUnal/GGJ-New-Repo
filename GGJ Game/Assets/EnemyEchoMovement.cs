using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyEchoMovement : MonoBehaviour {

	NavMeshAgent enemyAgentEcho;

	GameObject[] destinations;
	Vector3 patrolDst;

	int itemCount;
	int index;


	public static bool isOnTarget = false;

	public static GameObject targetPlayer;


	bool isStunned = false;

	public GameObject echoCircle;
	public GameObject aimObject;


	void Start () {

		isOnTarget = false;

		enemyAgentEcho = GetComponent<NavMeshAgent> ();
		destinations = GameObject.FindGameObjectsWithTag ("Destination");
		itemCount = destinations.Length;

		Debug.Log ("Assigning Initial Destination");
		index = Random.Range (0, itemCount);
		patrolDst = destinations [index].transform.position;
		enemyAgentEcho.SetDestination (patrolDst);
		StartCoroutine (Echolocation ());
	}


	void Update () {

		if(targetPlayer != null)
		Debug.Log (targetPlayer.name);

		if (isStunned)
			return;

		float dist = enemyAgentEcho.remainingDistance;
		if (isOnTarget == false) 
		{
			if (enemyAgentEcho.remainingDistance == 0) 
			{
				Debug.Log ("Assign Attempt");		
				AssignNewDestination ();
			}
		}

		if(isOnTarget == true)
		{	

			if(Vector3.Distance(targetPlayer.transform.position, this.transform.position) > 2)
			{

				enemyAgentEcho.Resume ();
				enemyAgentEcho.SetDestination (targetPlayer.transform.position);

			}
			else
			{
				enemyAgentEcho.Stop ();
				Vector3 lookVector = new Vector3 (targetPlayer.transform.position.x, transform.position.y, targetPlayer.transform.position.z);
				transform.LookAt (lookVector);
			}

		}

	}

	void AssignNewDestination()
	{
		Debug.Log ("Assigning New Destination");

		index = Random.Range (0, itemCount);
		patrolDst = destinations [index].transform.position;
		enemyAgentEcho.SetDestination (patrolDst);
	}



	public virtual void DisablePatrol()
	{
		Debug.Log ("Disable Patrol Called");
		enemyAgentEcho.ResetPath ();
	}
	public void MoveToMeleeEcho(GameObject target)
	{
		Debug.Log ("Move to Melee Called");
		targetPlayer = target;
		isOnTarget = true;
	}

	public virtual void InitiateStun ()
	{
		Debug.Log ("Initiate Stun Called");
		isStunned = true;
		StartCoroutine (StunEffect ());
	}

	IEnumerator StunEffect()
	{
		enemyAgentEcho.Stop ();
		Debug.Log ("Is Stunned");
		for(int i = 0; i<5; i++)
		{
			yield return new WaitForSeconds (1f);
		}
		enemyAgentEcho.Resume ();
		isStunned = false;
	}


	//
	IEnumerator Echolocation ()
	{
		while(true)
		{
			yield return new WaitForSeconds (7f);
			for (int k = 0; k < 4; k++) 
			{
				Instantiate (echoCircle, aimObject.transform.position, aimObject.transform.rotation);
				yield return new WaitForSeconds (0.5f);
			}
		}
	}

}
