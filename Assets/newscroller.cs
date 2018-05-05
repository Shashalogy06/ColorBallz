using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newscroller : MonoBehaviour {

	// Use this for initialization

	float scrollSpeed = -5f;
	Vector2 startPos;


	void Start () {

		startPos = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		float newpos = Mathf.Repeat (Time.time * scrollSpeed,20);
		transform.position = startPos + Vector2.up * newpos;
		
	}
}
