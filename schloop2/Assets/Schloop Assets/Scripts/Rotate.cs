using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {


	public int spd = 1;

	void Update () {
		transform.Rotate (Vector3.right * Time.deltaTime * spd);
	}

}
