using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleBrain : MonoBehaviour {

    public ballBrain ball;
    float restrainedY;
    // Use this for initialization

    void Start () {
        restrainedY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, restrainedY, 0f);
        transform.position = newPos;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ball")
        {
            //find the difference between the center of the paddle and the center of the ball
            float posDif = col.transform.position.x - transform.position.x;
            //knowing the paddle is 2 units wide, we can figure out the relative distance along the paddle, then feed an angle to the ball to add force
            ball.bounceHarder(posDif * .785f);
        }
    }
}
