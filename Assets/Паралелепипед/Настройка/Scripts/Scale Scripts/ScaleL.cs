using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleL : MonoBehaviour
{
	public static string lengthText;
	private Text Length;
	void Start()
	{
		Length = GetComponent<Text>();
	}
	void Update()
	{
		lengthText = Length.text.ToString();
	}
}
