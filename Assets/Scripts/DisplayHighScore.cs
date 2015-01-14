using UnityEngine;
using System.Collections;

public class DisplayHighScore : MonoBehaviour {

	string label;

	// Use this for initialization
	void Start () {
		TextMesh textMesh = GetComponent<TextMesh> ();
		label = textMesh.text;
		textMesh.text = label + PlayerPrefs.GetInt ("Highscore");
	}
}