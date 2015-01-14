﻿using UnityEngine;
using System.Collections;

public class DisplayLastScore : MonoBehaviour {

	string label;

	// Use this for initialization
	void Start () {
		TextMesh textMesh = GetComponent<TextMesh>();
		label = textMesh.text;
		textMesh.text = label + GameManager.Instance.lastScore;
	}
	

}
