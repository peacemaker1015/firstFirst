using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {
 
	public float spd = 1f;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Translate (spd*(-1f)*Time.deltaTime,0f,0f); //Time.deltaTime evens out speed depending on frame rate.
	}


	/*void OnDestroy()
	{
		if (gameObject.tag == "Car")
			gameObject.transform.parent.car_counter--;
		else if (gameObject.tag == "Missile")
			gameObject.transform.parent.missile_counter--;
		else if (gameObject.tag == "Stoplight")
			gameObject.transform.parent.light_counter--;
		else
			return;
	}*/
}
