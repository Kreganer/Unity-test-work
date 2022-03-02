using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleH : MonoBehaviour {

	public static string heightText;
	private Text Height;
	void Start () {
		Height = GetComponent<Text>();
	}
	void Update () {
		heightText = Height.text.ToString();
	}
}
