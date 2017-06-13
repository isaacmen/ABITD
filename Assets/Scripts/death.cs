using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {
	public AudioClip deathsound;

	private int lives;
	private AudioSource src;
	// Use this for initialization
	void Start () {
		src = gameObject.GetComponent<AudioSource> ();
	}

    public void death_happens() {
		GameObject player = GameObject.Find("Player");
		player.GetComponent<Checkpoints> ().lives--;
		lives = player.GetComponent<Checkpoints> ().lives;
		src = player.GetComponent<AudioSource> ();

		if (lives == 0) {
			src.clip = deathsound;
			src.Play ();
			SceneManager.LoadScene ("DeathScene");
		} else {
			string name = player.GetComponent<Checkpoints> ().currentCP;
			GameObject checkpoint = GameObject.Find(name);
			src.clip = deathsound;
			src.Play ();

			Vector3 new_pos = checkpoint.transform.position;
			new_pos.z -= 1.0f;
			player.transform.position = new_pos;
		}
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
