using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleW : MonoBehaviour
{
	public static string widthText;
	private Text Width;
	void Start()
	{
		Width = GetComponent<Text>();
	}
	void Update()
	{
		widthText = Width.text.ToString();
	}
}
