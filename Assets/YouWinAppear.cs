using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWinAppear : MonoBehaviour {
	public GameObject canvas;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	private void OnTriggerEnter(Collider other){

		if(other.gameObject.name == "Player")
		{
			Destroy (gameObject);
			gameObject.SetActive(canvas);
		}
	}
}
