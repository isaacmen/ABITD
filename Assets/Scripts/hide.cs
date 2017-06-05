using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hide : MonoBehaviour {

    public bool hidden = false;


	// Use this for initialization
	void Start () {
		
	}

    public bool isHidden() {
        return hidden;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("hideyhole")) 
        {
            Debug.Log("hidden");
            hidden = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("hideyhole"))
        {
            Debug.Log("not hidden");
            hidden = false;
        }
    }
	
	// Update is called once per frame
	void Update () {


	}
}
