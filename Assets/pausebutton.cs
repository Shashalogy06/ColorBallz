using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausebutton : MonoBehaviour {

	// Use this for initialization
	public Canvas retry_menu ;

	void Start () {
		retry_menu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pause ()
	{
		Time.timeScale = 0;
		retry_menu.enabled = true;
	}
	public void retry()
	{
		Time.timeScale = 1f;
		retry_menu.enabled = false;
		SceneManager.LoadScene ("scene");
	}
	public void back()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("mainmenu");

	}
	public void resume()
	{
		Time.timeScale = 1f;
		retry_menu.enabled = false;

	}
	public void credit()
	{
		SceneManager.LoadScene ("credits");
	}
}
