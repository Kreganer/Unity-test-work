using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B : MonoBehaviour
{

	public static string BlueText;
	private Text Blue;
	void Start()
	{
		Blue = GetComponent<Text>();
	}
	void Update()
	{
		BlueText = Blue.text.ToString();
	}
}
