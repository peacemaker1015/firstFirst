using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	public SpawnScript[] spawners; //When you drag a game object into this array through Unity's inspector, it automatically makes it an object of type SpawnScript instead of GameObject.
	public float spawnCount = 3f;
	
	void Update () 
	{

		if (spawnCount > 0) 
		{
			spawnCount -= Time.deltaTime;
		} 
		else if (spawnCount < 0) 
		{
			spawners [Random.Range (0, spawners.Length)].Spawn ();

			//print (spawnCount);
			spawnCount = 3f;
		}
	}
		
}
