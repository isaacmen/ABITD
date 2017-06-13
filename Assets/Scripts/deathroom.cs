using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathroom : MonoBehaviour {
	public Object monster;
	private AudioSource src;
	private bool change;
	private int timer;

	// Use this for initialization
	void Start () {
		src = gameObject.GetComponent<AudioSource> (); 
		change = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (change) {
			timer++;
		}
		if (timer > 90) {
			var deathscript = gameObject.GetComponent<death>();
			deathscript.death_happens();
		}
		
	}

	void FixedUpdate() {

	}


	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player")) {
			src.Play ();
			Instantiate (monster, this.transform.position, this.transform.rotation);
			change = true;
		}
	}
}
