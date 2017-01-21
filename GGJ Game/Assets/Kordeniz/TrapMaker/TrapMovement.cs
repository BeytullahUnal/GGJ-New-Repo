using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapMovement : MonoBehaviour {

	public int looper;
	public float WFS;
	public float xper;
	public float yper;
	public float zper;

	// Use this for initialization
	void Start () {
		StartCoroutine (Move3());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Move1(){

		for (int i = 0; i < looper; i++) {
			transform.Translate (xper, yper, zper);
			yield return new WaitForSeconds (WFS);
		}

	}

	IEnumerator Move2(){

		for (int i = 0; i < looper; i++) {
			transform.Translate (-xper, -yper, -zper);
			yield return new WaitForSeconds (WFS);
		}

	}

	IEnumerator Move3(){

		int a;

		while (true) {
			a = 1;

			if (a == 1) {
				yield return StartCoroutine (Move1 ());

			}
			a = 2;
			if (a == 2) {
				yield return StartCoroutine (Move2 ());

			}

		}



	}
}