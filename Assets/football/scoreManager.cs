using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

	public Text scoretext;
	//public Text Highscore;
	//int hs;
	int score;
	// Use this for initialization
	void Start () {
		score = 0;
		InvokeRepeating ("ScoreUpdate", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		//PlayerPrefs.SetInt ("hs", );
		scoretext.text = score.ToString();
		/*if (score > Highscore) {
			Highscore = score;
		}*/
	}

	public void ScoreUpdate()
	{
		score = score + 1;
	}
}
