using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealerAOE : MonoBehaviour {

	public int damage = 25;

	void Start () {
		Debug.Log ("my damage is: " + damage);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if(other.transform.tag == "Enemy")
		{
			Debug.Log (damage);
			EnemyHP enemyHP = other.gameObject.GetComponent<EnemyHP> ();
			enemyHP.ReceiveDamage (damage);
		}
		if(other.transform.tag == "EchoEnemy")
		{
			Debug.Log (damage);
			EnemyHP enemyHP = other.gameObject.GetComponent<EnemyHP> ();
			enemyHP.ReceiveDamage (damage);
		}
	}

}
