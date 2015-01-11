﻿using UnityEngine;
using System.Collections;

public class PsuedoMoveLeftAndRight : MonoBehaviour {

	public float speed = 1.0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		renderer.material.mainTextureOffset += Vector2.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
	}
}
