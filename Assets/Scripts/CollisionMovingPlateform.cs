﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMovingPlateform : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			other.transform.parent = transform.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			other.transform.parent = null;
		}
	}
}
