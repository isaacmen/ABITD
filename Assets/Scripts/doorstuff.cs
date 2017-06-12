using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorstuff : MonoBehaviour {

	private AudioSource src;
	private bool opened;
	private int timer;

	// Use this for initialization
	void Start () {
		src = gameObject.GetComponent<AudioSource> (); 
		opened = false;
		timer = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (opened) {
			timer++;
		}
		if (timer > 60) {
			GameObject.Destroy (this.gameObject);
		}
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player") && !opened) {
			bool key = col.gameObject.GetComponent<keycode> ().haskey;
			if (key) {
				src.Play ();
				opened = true;
			}
			col.gameObject.GetComponent<keycode> ().haskey = false;
		}
	}
}
