using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void play()
	{
		SceneManager.LoadScene ("scene");
		Debug.Log ("the play is pressed");
	}
	public void credit()
	{
		SceneManager.LoadScene ("credits");
		Debug.Log ("the debug is pressed");
	}
}
