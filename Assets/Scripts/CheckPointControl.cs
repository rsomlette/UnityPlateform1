﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointControl : MonoBehaviour {

	Animator anim;
	public bool isCheckpointActive;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			anim.SetBool ("isActivated", true);
			isCheckpointActive = true;
		}
	}
}
