using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moon_collide : MonoBehaviour {

	// Use this for initialization
//	public scoreManager scoreman;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "moon" || c.gameObject.tag == "e2")
		{
			//Debug.Log ("ball is colliding");
			//scoreman.scoreupdate (10);
			Destroy(gameObject);
		}
	}
}
