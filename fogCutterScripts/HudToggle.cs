using UnityEngine;
using System.Collections;

public class HudToggle : MonoBehaviour {
	private Canvas CanvasObject; // Assign in inspector

	void Start()
	{
		CanvasObject = GetComponent<Canvas> ();
	}

	void Update() 
	{
		if (Input.GetKeyUp(KeyCode.Escape)) //hide hud on "escape" button press
		{
			CanvasObject.enabled = !CanvasObject.enabled;
		}
	}
}