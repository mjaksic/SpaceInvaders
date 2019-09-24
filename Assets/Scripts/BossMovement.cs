using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {

    public float speed = 0.0f;
    public float amountLeft = 0.0f;
    public float amountRight = 0.0f;
    private bool direction = true;
	
	// Update is called once per frame
	void Update () {
        if (direction)
            transform.Translate(Vector2.right * speed/10 * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed/10 * Time.deltaTime);

        if (transform.position.x >= amountRight)
        {
            direction = false;
        }

        if (transform.position.x <= amountLeft)
        {
            direction = true;
        }
    }
}
