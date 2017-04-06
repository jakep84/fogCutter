using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Start location service
		Input.location.Start ();
		//Enable compass 
		Input.compass.enabled = true;
	}

	// Update is called once per frame
	void Update ()
	{
		//Create a variable to put the device ".trueHeading" in
		var heading = Input.compass.trueHeading;
		//Change object z axis rotation based on heading variable 
		transform.eulerAngles = new Vector3 (0, 0, heading);
	}
}