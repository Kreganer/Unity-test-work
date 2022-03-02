using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class R : MonoBehaviour
{

	public static string RedText;
	private Text Red;
	void Start()
	{
		Red = GetComponent<Text>();
	}
	void Update()
	{
		RedText = Red.text.ToString();
	}
}
