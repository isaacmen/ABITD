﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {

    public bool can_move = true;
    public float speed = 0.025f;

    public GameObject monster_prefab;
    bool monster_check = false;
	public bool walking = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        Quaternion rot = transform.rotation;

		if (Input.GetKey (KeyCode.W) && can_move) {
			transform.position = new Vector3 (pos.x, pos.y + speed, pos.z);
			transform.eulerAngles = new Vector3 (0.0f, 0.0f, 0.0f);
			walking = true;
			//transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
		} else if (Input.GetKey (KeyCode.S) && can_move) {
			transform.position = new Vector3 (pos.x, pos.y - speed, pos.z);
			transform.eulerAngles = new Vector3 (0.0f, 0.0f, 180.0f);
			walking = true;
			//transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
		} else if (Input.GetKey (KeyCode.A) && can_move) {
			transform.position = new Vector3 (pos.x - speed, pos.y, pos.z);
			transform.eulerAngles = new Vector3 (0.0f, 0.0f, 90.0f);
			walking = true;
			//transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
		} else if (Input.GetKey (KeyCode.D) && can_move) {
			transform.position = new Vector3 (pos.x + speed, pos.y, pos.z);
			transform.eulerAngles = new Vector3 (0.0f, 0.0f, 270.0f);
			walking = true;
			//transform.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
		} else {
			walking = false;
		}

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Test");
        }

        if (pos.x < -3.6 && monster_check == false) 
        { 
            Instantiate(monster_prefab, pos, transform.rotation);
            monster_check = true;
        }

	}
}
