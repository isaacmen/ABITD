using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorstuff : MonoBehaviour {

	private AudioSource src;
	private bool opened;

	// Use this for initialization
	void Start () {
		src = gameObject.GetComponent<AudioSource> (); 
		opened = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player") && !opened) {
			src.Play();
			opened = true;
		}
	}
}
