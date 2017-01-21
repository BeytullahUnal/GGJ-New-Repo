using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

	float maxHP = 50;
	float currentHP;

	void Start () {

		currentHP = maxHP;
	}
	
	// Update is called once per frame
	void Update () {

		if(currentHP <= 0)
		{
			Destroy (gameObject);
		}

	}


	public virtual void ReceiveDamage(int amount)
	{
		currentHP -= amount;
	}

}
