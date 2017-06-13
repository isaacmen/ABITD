using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstep : MonoBehaviour {
	private bool sound_on;
	private bool isWalking;
	private AudioSource src;

	// Use this for initialization
	void Start () {
		sound_on = false;
		src = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		isWalking = gameObject.GetComponentInParent<movement> ().walking;

		if (isWalking) {
			if (sound_on) {
				src.Play ();
				sound_on = false;
			}
		} else {
			src.Stop ();
			sound_on = true;
		}
	}
}
