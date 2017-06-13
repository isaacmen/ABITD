using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {
	private int lives;

	// Use this for initialization
	void Start () {
	}

    public void death_happens() {
		GameObject player = GameObject.Find("Player");
		player.GetComponent<Checkpoints> ().lives--;
		lives = player.GetComponent<Checkpoints> ().lives;

		if (lives == 0) {
			SceneManager.LoadScene ("DeathScene");
		} else {
			string name = player.GetComponent<Checkpoints> ().currentCP;
			GameObject checkpoint = GameObject.Find(name);

			Vector3 new_pos = checkpoint.transform.position;
			new_pos.z -= 1.0f;
			player.transform.position = new_pos;
		}
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
