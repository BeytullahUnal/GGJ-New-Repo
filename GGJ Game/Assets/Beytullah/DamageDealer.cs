using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour {

	public int damage = 15;

	void Start () {
		Debug.Log ("my damage is: " + damage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Enemy")
		{
			Debug.Log (damage);
			EnemyHP enemyHP = other.gameObject.GetComponent<EnemyHP> ();
			enemyHP.ReceiveDamage (damage);
		}
		if(other.gameObject.tag == "EchoEnemy")
		{
			Debug.Log (damage);
			EnemyHP enemyHP = other.gameObject.GetComponent<EnemyHP> ();
			enemyHP.ReceiveDamage (damage);
		}
	}

}
