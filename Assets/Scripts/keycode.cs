using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode : MonoBehaviour {

	public bool haskey;
	public AudioClip keysound;

	private AudioSource src;

	// Use this for initialization
	void Start () {
		haskey = false;
		src = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Key") && !haskey) {
			haskey = true;
			src.clip = keysound;
			src.Play ();
			GameObject.Destroy (col.gameObject);
		}
	}
}
