﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOverTime : MonoBehaviour {

	public float lifeTime = 1.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime = lifeTime - Time.deltaTime;
		if (lifeTime <= 0f) {
			Destroy (gameObject);
		}
	}
}
