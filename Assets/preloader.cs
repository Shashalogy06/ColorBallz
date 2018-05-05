using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class preloader : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (example() );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator example()
	{
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("mainmenu");
	}
}
