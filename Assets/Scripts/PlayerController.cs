using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
	public float speed;

	void Start()
	{

	}

	void Update () {
		float lr = Input.GetAxis ("Horizontal");
		float ud = Input.GetAxis ("Vertical");

		transform.Translate (lr*speed*Time.deltaTime, ud*speed*Time.deltaTime, 0f );
	}
}
