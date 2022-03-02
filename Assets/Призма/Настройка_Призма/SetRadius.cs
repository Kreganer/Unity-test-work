using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRadius : MonoBehaviour {

	public static string radiusText;
	private Text Radius;
	void Start()
	{
		Radius = GetComponent<Text>();
	}
	void Update()
	{
		radiusText = Radius.text.ToString();
	}
}
