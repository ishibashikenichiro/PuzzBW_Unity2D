﻿using UnityEngine;
using System.Collections;

public class bh : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Euler (0, 0, 120);
	}
}
