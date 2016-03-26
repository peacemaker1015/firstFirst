using UnityEngine;
using System.Collections;

public class SchloopController : MonoBehaviour
{
	/*bool spacePressed = false; //Has space been pressed?
	Animator anim; //Helps me manipulate animations.
	public Rigidbody2D body; //Helps me manipulate properties of a rigidBody2D.
	float move = 4f; //How high schloop jumps and descends!

	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		anim.SetBool ("IsPressed", spacePressed);

		if (Input.GetKeyDown(KeyCode.Space) && spacePressed == false) 
		{
			spacePressed = true;
			body.MovePosition(new Vector2 (body.position.x, body.position.y + move));
		}
		else if (Input.GetKeyDown(KeyCode.Space))
		{
			spacePressed = false;
			body.MovePosition(new Vector2 (body.position.x, body.position.y - move));
		}
		else
			print("plz work");
	}*/

	float maxHeight = 4.1f;
	float minHeight = -2f;
	float move = 3.05f;
	 
	Animator anim;
	bool offground = false;
	public Rigidbody2D body;

	void Start ()
	{
		anim = GetComponent<Animator> ();
		body = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		anim.SetBool ("offGround", offground);

		if (Input.GetKeyDown (KeyCode.UpArrow) && (body.position.y < maxHeight))
			body.MovePosition (new Vector2 (body.position.x, body.position.y + move));
		else if (Input.GetKeyDown (KeyCode.DownArrow) && (body.position.y > minHeight))
			body.MovePosition (new Vector2 (body.position.x, body.position.y - move));

		if (body.position.y > minHeight)
			offground = true;
		else
			offground = false;
	}
}

