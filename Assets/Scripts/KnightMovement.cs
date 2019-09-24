using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public float knightMovementSpeed;
    private Rigidbody2D knightRigidbody;
    private Animator knightAnimator;
    private bool knightMoving;
    private Vector2 lastMove;

	// Use this for initialization
	void Start ()
    {
        knightAnimator = GetComponent<Animator>();
        knightRigidbody = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        knightMoving = false;

        //omogucavanje kretnji
		if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            //transform.Translate (new Vector3 (Input.GetAxisRaw("Horizontal") * knightMovementSpeed * Time.deltaTime, 0f, 0f));
            knightRigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * knightMovementSpeed, knightRigidbody.velocity.y);
            knightMoving = true;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        }
        if (Input.GetAxisRaw ("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            //transform.Translate (new Vector3 (0f, Input.GetAxisRaw("Vertical") * knightMovementSpeed * Time.deltaTime, 0f));
            knightRigidbody.velocity = new Vector2(knightRigidbody.velocity.y, Input.GetAxisRaw("Vertical") * knightMovementSpeed);
            knightMoving = true;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
        }

        //zaustavljanje kretnji i epilepsije
        if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
        {
            knightRigidbody.velocity = new Vector2(0f, knightRigidbody.velocity.y);
        }
        if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
        {
            knightRigidbody.velocity = new Vector2(knightRigidbody.velocity.x, 0f);
        }

        //animacije
        knightAnimator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        knightAnimator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        knightAnimator.SetBool("KnightMoving", knightMoving);
        knightAnimator.SetFloat("LastMoveX", lastMove.x);
        knightAnimator.SetFloat("LastMoveY", lastMove.y);
	}
}
