using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shifting : MonoBehaviour {
	public float speed;
	public Rigidbody2D player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("d")) {

			player.transform.Translate(speed*Time.deltaTime,0,0);
		}
		if (Input.GetKey ("a")) {

			player.transform.Translate(-1f*speed*Time.deltaTime,0,0);
		}
	}
}
