using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monsterSpawner : MonoBehaviour {

    public bool can_spawn = true;
    public GameObject player;
    public GameObject monster_prefab;

    //int spawnRate = 5; // in percent

    float timer = 0;
    float next_time = 500;

    private GameObject currentMonster;


	// Use this for initialization
	void Start () {
        var playerPos = player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y - 9, playerPos.z);
	}
	
	// Update is called once per frame
	void Update () {

        // keep spawner behind and certain distance from player
        var pos = transform.position;
        var playerPos = player.transform.position;
        transform.position = new Vector3(playerPos.x, playerPos.y - 9, pos.z);
        pos = transform.position;

        //spawn points
        
        var up = pos;
        var down = new Vector3(playerPos.x, playerPos.y + 9, pos.z);
        var left = new Vector3(playerPos.x - 9, playerPos.y, pos.z);
        var right = new Vector3(playerPos.x + 9, playerPos.y, pos.z);
        Vector3[] directions = { up, down, left, right };
        string[] directions_names = { "up", "down", "left", "right" };

        // monster takes random time to spawn
        if (can_spawn && timer >= next_time && currentMonster == null)
        {
            Debug.Log("ping: " + next_time);

            int dir = Random.Range(0, 4);
            currentMonster = Instantiate(monster_prefab, directions[dir], transform.rotation);
            var monScript = currentMonster.GetComponent<monster>();
            monScript.direction = directions_names[dir];

            float r = Random.Range(1000.0f, 2000.0f);
            next_time = r;
            timer = 0;

        }
        else { timer++; }

        var pscript = player.GetComponent<movement>();
        if (pscript.can_move == false)
        {
            can_spawn = false;
        }

	}
}
