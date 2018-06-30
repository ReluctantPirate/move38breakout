using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballBrain : MonoBehaviour {

    public bool inPlay;
    float ballSpeed;
    public Text instructionText;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//lazy way of checking if the user is clicking
        if (Input.GetMouseButtonDown(0) && !inPlay)
        {
            ballSpeed = 200f;
            startBall();
        }
	}

    public void startBall()
    {
        //this is called when the user clicks at the beginning of a new life
        instructionText.text = " ";
        //give the ball a small initial velocity, and a random downward trajectory
        inPlay = true;
        float initialDirection = Random.Range(2.355f, 3.925f);
        GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed * Mathf.Sin(initialDirection), ballSpeed * Mathf.Cos(initialDirection)));
    }

    public void resetBall()
    {
        //called by the bottom barrier when it collides
        inPlay = false;
        transform.position = new Vector2(0, 0);
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    public void bounceHarder(float angle)
    {
        //called by the paddle, arrests force, adds a new force with some angle
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ballSpeed += 20f;
        GetComponent<Rigidbody2D>().AddForce(new Vector2(ballSpeed * Mathf.Sin(angle), ballSpeed * Mathf.Cos(angle)));
    }
}
