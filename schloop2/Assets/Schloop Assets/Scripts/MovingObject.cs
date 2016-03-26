using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {
 
	public float spd = 1f;
	public float rotate_spd = 1f;

	public Transform prnt;

	// Use this for initialization
	void Start () {

		prnt = transform.parent;
	
	}

	// Update is called once per frame
	void Update () {

		transform.Translate (spd*(-1f)*Time.deltaTime,0f,0f); //Time.deltaTime evens out speed depending on computer's frame rate.

		if (gameObject.tag == "Powerup")
			transform.Rotate (rotate_spd * Time.deltaTime, 0, 0);
	}


	void OnDestroy()
	{
		//print ("I DIED");

		/*if (prnt) 
		{
			if (gameObject.tag == "Car")
				prnt.car_counter--;
			else if (gameObject.tag == "Missile")
				prnt.missile_counter--;
			else if (gameObject.tag == "Stoplight")
				prnt.light_counter--;
			else if (gameObject.tag == "Powerup")
				prnt.powerup_counter--;
		}*/

	}
}
