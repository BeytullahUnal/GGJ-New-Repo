//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.AI;

//public class EnemyCombat : MonoBehaviour {

//    NavMeshAgent combatNav;

//    GameObject targetPlayer;
//    Vector3 initialLocation;
//    Vector3 newLocation;



//    void Start () {
//        combatNav = GetComponent<NavMeshAgent> ();
//    }
	

//    void Update () {
//        if (targetPlayer != null) {
//            initialLocation = targetPlayer.transform.position;
//            combatNav.SetDestination (initialLocation);
//        }
//    }

//    public virtual void MoveToMelee(GameObject target)
//    {
//        Debug.Log ("Move to Melee Called");
//        targetPlayer = target;


//    }

//}
