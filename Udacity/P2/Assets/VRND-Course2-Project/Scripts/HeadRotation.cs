﻿using UnityEngine;
using System.Collections;

public class HeadRoration : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		Quaternion att = Input.gyro.attitude;
		att = Quaternion.Euler (90f, 0f, 0f) * new Quaternion (att.x, att.y, -att.z, -att.w);
		transform.rotation = att;
	}
}
