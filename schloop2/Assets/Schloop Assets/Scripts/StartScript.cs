using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{

		if (GUI.Button (new Rect (Screen.width / 2 - 30, 350, 60, 30), "START"))
			Application.LoadLevel (1);

	}
}
