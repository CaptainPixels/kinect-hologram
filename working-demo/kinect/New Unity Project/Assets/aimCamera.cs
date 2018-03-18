using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimCamera : MonoBehaviour {

    public Transform target;
	
	// Update is called once per frame
	void Update () {
        Vector3 upVector = new Vector3(0.0f, 1.0f, 0.0f);

        Vector3 CubePosition = GameObject.Find("Cube").transform.position;
        transform.LookAt(CubePosition, upVector);
	}
}
