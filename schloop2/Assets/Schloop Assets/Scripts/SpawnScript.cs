using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public GameObject temp;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	//Here are all my counters. Remember, Taylor, these are PER SPAWNER. D:
	public float car_counter = 0;
	public float missile_counter = 0;
	public float light_counter = 0;
	public float powerup_counter = 0;

	void Start () {
			Spawn ();
	}

	void Spawn()
	{
		//temp = obj[Random.Range(0, obj.Length)];

		temp = (GameObject)Instantiate (obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);

		temp.transform.parent = gameObject.transform;
		//print ("MY PARENT IS " + temp.transform.parent.name);

		switch (temp.tag) 
		{
		case "Car":
			car_counter++;
			print ("+CAR");
			break;
		case "Missile":
			missile_counter++;
			print ("+MISSILE");
			break;
		case "Stoplight":
			light_counter++;
			print ("+STOPLIGHT");
			break;
		case "Powerup":
			powerup_counter++;
			print ("+POWERUP");
			break;
		default:
			print ("Something weird has spawned...");
			break;
		}

		print (gameObject.name + "is currently: " + car_counter + " " + missile_counter + " " + light_counter + " " + powerup_counter);

		// We're going to set a counter for each object so we limit the amount of them spawned PER ROW.
		if ((car_counter + missile_counter + light_counter + powerup_counter) <= 3)
			Invoke ("Spawn", Random.Range(spawnMin,spawnMax));

	}
		

}
