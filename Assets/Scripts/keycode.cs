using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode : MonoBehaviour {

	public bool haskey;

	// Use this for initialization
	void Start () {
		haskey = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Key") && !haskey) {
			haskey = true;
			GameObject.Destroy (col.gameObject);
		}
	}
}
