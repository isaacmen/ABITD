using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monster : MonoBehaviour {

    int move = 10; // how far monster goes before disappearing
    float speed = 2.0f; // 3
    Vector3 initialPos;

    //bool hunting = true;
    public bool stop = false;
    bool passover = false;
    public string direction = "up";

	// Use this for initialization
	void Start () {
        initialPos = transform.position;
	}

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("hider"))
        {
            var hscript = other.GetComponent<hide>();
            bool playerIsHidden = hscript.isHidden();
            if (!playerIsHidden)
            {
                Debug.Log("monster: D:<");
                // insert player dies here
                GameObject player = GameObject.Find("Player");
                var pscript = player.GetComponent<movement>();
                
                pscript.can_move = false;
                stop = true; // monster stops

                // death screen
                SceneManager.LoadScene("DeathScene");
            }
            else 
            {
                //Debug.Log("monster: passing over...");
                passover = true;
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        GameObject player = GameObject.Find("Player");
        var playerPos = player.transform.position;
        
        if (!stop) 
        {

            float diff = Mathf.Abs(playerPos.y - pos.y);
            float diff2 = Mathf.Abs(playerPos.x - pos.x);
            if (diff >= move || diff2 >= move) { Destroy(gameObject); }
            else
            {
                if (direction == "up")
                {
                    transform.position = new Vector3(pos.x, pos.y + (speed * Time.deltaTime), pos.z);
                }
                else if (direction == "down")
                {
                    transform.position = new Vector3(pos.x, pos.y - (speed * Time.deltaTime), pos.z);
                }
                else if (direction == "left")
                {
                    transform.position = new Vector3(pos.x + (speed * Time.deltaTime), pos.y, pos.z);
                }
                else if (direction == "right")
                {
                    transform.position = new Vector3(pos.x - (speed * Time.deltaTime), pos.y, pos.z);
                }
            } 

            /*
            if (passover)
            {
                float diff2 = Mathf.Abs(playerPos.y - pos.y);
                if (diff2 <= move) // pos.y <= initialPos.y + move
                {
                    transform.position = new Vector3(pos.x, pos.y + (speed * Time.deltaTime), pos.z);
                }
                else { Destroy(gameObject); }
            }
             */
        }
        
	}
}
