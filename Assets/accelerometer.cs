using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour {
	public float speed= 10f;
	Vector3 position;
	// Use this for initialization
	void Start () {
		
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float t = Input.acceleration.x;
		transform.Translate (t * speed * Time.deltaTime, 0, 0);
		position.x = Mathf.Clamp (position.x, -3.2f, 3.0f);
	}
}
