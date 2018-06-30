using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathBrain : MonoBehaviour {

    public ballBrain ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D()
    {
        ball.resetBall();
    }
}
