using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			Debug.Break ();
			return;
		}

		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject); //If the game object has a parent, destroy the parent. Is this necessary for us? 
		}
		else if (gameObject.tag != "Destroyer" && (other.tag == "Car" || other.tag == "Missile" || other.tag == "Stoplight" || other.tag == "Powerup")) 
		{
			print ("We didn't kill each other."); //Do nothing. Enemies shouldn't touch anyway, but just in case...
		}
		else 
		{
			Destroy (other.gameObject);
		}
	}
}
