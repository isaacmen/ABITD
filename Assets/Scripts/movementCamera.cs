using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementCamera : MonoBehaviour {

    public GameObject positionref_cam;
    public float speed = 1.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position; // position of camera (this)
        Vector3 campos = positionref_cam.transform.position;

        transform.position = new Vector3(campos.x, campos.y, pos.z);
	}
}
