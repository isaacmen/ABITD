using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMove : MonoBehaviour {
	

	void Update () {
		bool right = Input.GetKey ("e");
		bool left = Input.GetKey ("q");

		if (right) 
		{
			Vector3 move = new Vector3 (0.0f, 0.0f, -2.0f);
			transform.Rotate (move);
		}

		if (left) 
		{
			Vector3 move = new Vector3 (0.0f, 0.0f, 2.0f);
			transform.Rotate (move);
		}

		this.transform.position = this.transform.parent.transform.position;
	}
}
