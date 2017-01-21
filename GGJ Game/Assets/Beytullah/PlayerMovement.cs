using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;


public class PlayerMovement : MonoBehaviour {

	NavMeshAgent navAgent;
    public float moveSpeed = 6f;

	Vector3 transitionDir;
	Vector3 moveDirection;

	Vector3 castTransitionDir;
	Vector3 castAimDirection;

	public bool isCasting = false;
	public GameObject aimPlane;

	public Animation walkAnim;
	bool isWalking = false;



	void Start () {

		navAgent = GetComponent<NavMeshAgent> ();
		
	}
	

	void Update () {

		if(navAgent.pathStatus != NavMeshPathStatus.PathComplete && walkAnim.isPlaying == false)
		{
			//isWalking = true;

			walkAnim.Play ();
		}
		if(navAgent.pathStatus == NavMeshPathStatus.PathComplete)
		{
			walkAnim.Stop ();
		}

		if(isCasting == true)
		{
			walkAnim.Stop ();
			navAgent.ResetPath ();
			aimPlane.SetActive (true);
		}
		if(isCasting == false)
		{
			aimPlane.SetActive (false);
		}
		       
		if (Input.GetMouseButton(1) && isCasting == false)
		{	
			//isCasting = false;


			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit))
			{
				
				transitionDir = hit.point;
				moveDirection = new Vector3(transitionDir.x, this.transform.position.y, transitionDir.z);

				navAgent.SetDestination (moveDirection);
			}
		}


		if(Input.GetKey(KeyCode.Alpha1))
		{
			isCasting = true;
		}

		if(isCasting == true)
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				castTransitionDir = hit.point;
				castAimDirection = new Vector3 (castTransitionDir.x, this.transform.position.y, castTransitionDir.z);
				transform.LookAt (castAimDirection);

			}
		}


        
		
	}
}
