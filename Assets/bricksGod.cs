using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bricksGod : MonoBehaviour {

    public ballBrain ball;
    public Text instructionText;
    bool gameOver;
    // Use this for initialization
    void Start () {
        gameOver = false;		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount == 0 && gameOver == false)
        {
            //No more bricks, game over
            ball.resetBall();
            ball.inPlay = true;//this is just so you can't launch it again on click
            gameOver = true;
            instructionText.text = "VICTORY!";
        }
	}
}
