using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Меню : MonoBehaviour {

	public static string value1Text;
	public static int value1;
	public Text text;
	public void OnValueChanded(int value)
    {
		if (value == 1)
		{
			text.text = "Вы выбрали:" + "Паралелепипед";
			value1 = value;
		}
		if (value == 2)
		{
			text.text = "Вы выбрали:"+ "Сферу";
			value1 = value;
		}
		if (value == 3)
		{
			text.text = "Вы выбрали:" + "Призму";
			value1 = value;
		}
		if (value == 4)
		{
			text.text = "Вы выбрали:" + "Капсулу";
			value1 = value;
		}
	}
	public void OnStartHandler()
	{
		if (value1 == 1) 
		{
			SceneManager.LoadScene(1);
		}
		if (value1 == 2)
		{
			SceneManager.LoadScene(3);
		}
		if (value1 == 3)
		{
			SceneManager.LoadScene(2);
		}
		if (value1 == 4)
		{
			SceneManager.LoadScene(4);
		}
	}
	public void OnExitHandler()
	{
		Application.Quit();
	}
}
