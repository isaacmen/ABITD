using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoints : MonoBehaviour {
	public string currentCP;
	public int lives;
	public Text lifecount;

	// Use this for initialization
	void Start () {
		currentCP = "CheckPoint1";
		lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		lifecount.text = "Lives: " + lives.ToString();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Checkpoint1")) {
			currentCP = "CheckPoint1";
		}
		if (col.CompareTag ("Checkpoint2")) {
			currentCP = "CheckPoint2";
		}
		if (col.CompareTag ("Checkpoint3")) {
			currentCP = "CheckPoint3";
		}
	}
}
