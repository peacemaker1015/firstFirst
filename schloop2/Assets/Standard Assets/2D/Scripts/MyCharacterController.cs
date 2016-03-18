using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour
{
	public float maxSpeed = 10f;
	bool facingRight = true; 

	Animator anim;
	public Rigidbody2D body;

	bool grounded = false; //This tells me if the character is on the ground.
	public Transform groundCheck; //Where the ground should be.
	float groundRadius = 0.2f; //Where we check for ground.
	public LayerMask whatIsGround;
	public float jumpForce = 700f;

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", body.velocity.y);

		float move = Input.GetAxis("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		body.velocity = new Vector2 (move * maxSpeed, body.velocity.y);
		
		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update()
	{
		if (grounded && Input.GetKeyDown (KeyCode.Space)) //If we aren't grounded and space is pressed...
		{
			anim.SetBool ("Ground", false); //Change "Ground" to show that we aren't grounded
			body.AddForce (new Vector2 (0, jumpForce)); //...and jump! I should change this for my purposes.
		}
	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}

