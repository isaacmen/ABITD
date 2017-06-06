using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creak : MonoBehaviour {
    // make sure a Spawner gameobject with the monsterSpawner script is present

    public AudioClip creaksound;
    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("creaker")) 
        {
            Debug.Log("creak");
            source.PlayOneShot(creaksound);
            //source.Play(creaksound);
            // increase monster spawn speed
            GameObject spawner = GameObject.Find("Spawner");
            var spawn_script = spawner.GetComponent<monsterSpawner>();
            spawn_script.spawn_faster();
        }
    }

}
