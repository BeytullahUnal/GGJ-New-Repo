using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPUI : MonoBehaviour
{

	public Image HPYellow;
	public bool coolingDown;
	public float waitTime = 30.0f;
	int x;
	// Update is called once per frame
	void Start () 
	{
		StartCoroutine (HPY1 ());
	}

	IEnumerator HPY1()
	{
		for (x = 0; x < 10; x++) 
		{
			HPYellow.fillAmount += 0.1f;
			yield return new WaitForSeconds (.06f);
		}
		HPYellow.fillAmount = 0;
		yield return StartCoroutine (HPY1 ());
	}


}
