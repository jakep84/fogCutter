using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateGPStext : MonoBehaviour 
{
	public Text coordinates;
	private void Update()
	{
		coordinates.text = GPS.Instance.latitude.ToString () + "  |  " + GPS.Instance.longitude.ToString(); 
	}

}
