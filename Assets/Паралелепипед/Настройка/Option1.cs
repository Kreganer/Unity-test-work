using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Option1 : MonoBehaviour
{
	public void OnBackHandler()
	{
		SceneManager.LoadScene(0);
	}
}
