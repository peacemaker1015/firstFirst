using UnityEngine;
using System; //Added this for Array.Sort()
using System.Collections.Generic;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	static public List<int> topScores = new List<int>(50);

	int score = 0;

	static bool firstDeath = true;

	// Use this for initialization
	void Start () 
	{
		if (firstDeath)
			topScores.AddRange(PlayerPrefsX.GetIntArray("highScores"));
			firstDeath = false;
		score = PlayerPrefs.GetInt ("Score");
		addScore ();
		getScores();
	}

	public void addScore()
	{

		if (topScores.Count < topScores.Capacity) 
		{
			topScores.Add (score);
			topScores.Sort ();
			//print ("I added your high score!");
		} 
		else 
		{
			topScores.Add (score);
			topScores.Sort();
			topScores.TrimExcess();
			//print ("I dropped your lowest score!");
		}
			
	}

	public void getScores ()
	{
		for(int x = topScores.Count; x > 0; x--)
			print((topScores.Count - x + 1) + ". " + topScores[x-1]);
	}

	void OnGUI()
	{
		GUI.Label (new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);

		if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 60, 30), "Retry?"))
			Application.LoadLevel (1);

	}

	void OnApplicationQuit()
	{
		PlayerPrefsX.SetIntArray ("highScores", topScores.ToArray ());
		Debug.Log("Game saved.");
	}

}
