﻿using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour
{
	float playerScore = 0;
	//GameOverScript script;
	
	// Update is called once per frame
	void Update () {
		playerScore += Time.deltaTime;
	}

	public void IncreaseScore(int amount)
	{
		playerScore += amount;
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt("Score", (int)(playerScore * 100));

		//script.addScore ((int) playerScore * 100);
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "Score: " + (int)(playerScore * 100));
	}
}

