﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float Speed = 5.0f;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (Vector3.left * Time.deltaTime * Speed);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (Vector3.right * Time.deltaTime * Speed);
		}
	}
}
