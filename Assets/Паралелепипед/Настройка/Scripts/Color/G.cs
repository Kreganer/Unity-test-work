using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class G : MonoBehaviour
{

	public static string GreenText;
	private Text Green;
	void Start()
	{
		Green = GetComponent<Text>();
	}
	void Update()
	{
		GreenText = Green.text.ToString();
	}
}
