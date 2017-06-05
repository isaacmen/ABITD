using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTemp : MonoBehaviour {

    public GameObject monster_prefab;

    private GameObject monster;

	// Use this for initialization
	void Start () {
		
	}

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("triggered");
        if (other.CompareTag("player")) 
        {
            Debug.Log("Surprise!");
            var playerPos = other.transform.position;
            monster = Instantiate(monster_prefab, playerPos, transform.rotation);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
