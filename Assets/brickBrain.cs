﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brickBrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
