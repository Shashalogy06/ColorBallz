using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_collide : MonoBehaviour {

	// Use this for initialization
	public Canvas gameover;

	public bool isGameOver = false;
	 
	void Start () {
		gameover.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D c)
	{
		if (c.gameObject.tag == "enemy" || c.gameObject.tag == "e2" )
		{
			//Debug.Log ("ball is colliding");

			isGameOver = true;
			Destroy(gameObject);

			gameover.enabled = true;
			Time.timeScale = 0f;
		}
	}
     
}
