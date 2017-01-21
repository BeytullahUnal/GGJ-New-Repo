using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = Camera.main.transform.position - this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = this.transform.position + offset;
	}
}
