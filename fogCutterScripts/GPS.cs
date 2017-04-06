using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour 
{
	public static GPS Instance {set; get;}

	public float latitude;
	public float longitude;

	private void Start()
		{
			Instance = this;
			DontDestroyOnLoad (gameObject);
			StartCoroutine (StartLocationService ());
		}
	private IEnumerator StartLocationService()
	{
		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser) 
		{
			Debug.Log ("User has not enabled GPS");
			yield break;
		}
		// Start service before querying location
		Input.location.Start();

		// Wait until service initializes
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) 
		{
			yield return new WaitForSeconds (1);
			maxWait--;

		}

		// Service didn't initialize in 20 seconds
		if (maxWait < 1) 
		{
			Debug.Log("Timed out");
			yield break;
		}

		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed) 
		{
			Debug.Log ("Unable to determine device location");
			yield break;
		}

		latitude = Input.location.lastData.latitude;
		longitude = Input.location.lastData.longitude;
	}


		
}
