using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetCircle : MonoBehaviour {

	public static string circleText;
	private Text Circle;
	void Start()
	{
		Circle = GetComponent<Text>();
	}
	void Update()
	{
		circleText = Circle.text.ToString();
	}
}
