using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {
	public GameObject[] balls;
	public int v;
	// Use this for initialization
	void Start () {
		StartCoroutine(Example());
		timer ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	//	timer ();

	}

	void timer()
	{
		v = Random.Range (0,balls.Length);
		Vector3 pos = new Vector3 (Random.Range (-3f, 3f), 5.79f, 0);
		Instantiate (balls [v],pos, Quaternion.identity);
		Example ();
	}
	IEnumerator Example()
	{
	//	print(Time.time);
		yield return new WaitForSeconds(0.5f);
		Start ();
	//	print(Time.time);
	}
}
