using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj1 : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D ob1;
	public float speed;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ob1.transform.Translate (0, speed * Time.deltaTime, 0);
	}
}
