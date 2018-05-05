using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		Vector2 offSet = new Vector2 (0,Time.time * speed);
		GetComponent<Renderer>().material.mainTextureOffset = offSet;

	}
}