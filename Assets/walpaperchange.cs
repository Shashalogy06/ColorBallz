using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walpaperchange : MonoBehaviour {

	// Use this for initialization
	public GameObject[] arr;
	public int count=0;
	int i;
	void Start () {
		for (int j = 0; j < arr.Length; j++) {
			arr [j].SetActive (false);
		}
		arr [0].SetActive (true);
		i=0;
	}
	
	// Update is called once per frame
	void Update () {
		count++;
		if (count == 600) {
			for (int j = 0; j < arr.Length; j++) {
				arr [j].SetActive (false);
			}
			i++;
			if (i == 3)
				i = 0;
			arr [i].SetActive (true);
			count = 0;
		}
	}
}
