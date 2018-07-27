using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platercontroller : MonoBehaviour {
    Rigidbody playerRigidbody;
    public float turnSpeed;
    // Use this for initialization
    void Start() {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (0, 0, .25f);
		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (0, 0, -.25f);
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (0, -turnSpeed, 0);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (0, turnSpeed, 0);
       
    
	}

	void OnCollisionEnter (Collision col) {
		playerRigidbody.velocity = Vector3.zero;
	}

	void FixedUpdate () {
        playerRigidbody.velocity = Vector3.zero;
    }
     
}
