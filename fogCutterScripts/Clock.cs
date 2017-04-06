using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour {

	public Text clockText;

	void Update()
	{
		System.DateTime time = System.DateTime.Now;

		clockText.text = time.ToString("H:mm");
	}
}
