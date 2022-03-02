using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSet : MonoBehaviour 
{
	public void ChangeColor()
	{
		string Red = R.RedText;
		string Green = G.GreenText;
		string Blue = B.BlueText;
		if (Red == "" & Green == "" & Blue == "")
		{
			Red = "1";
			Green = "1";
			Blue = "1";
		}
		int R1 = int.Parse(Red);
		int G1 = int.Parse(Green);
		int B1 = int.Parse(Blue);
		gameObject.GetComponent<Renderer>().material.color = new Color(R1, G1, B1);
	}
}
