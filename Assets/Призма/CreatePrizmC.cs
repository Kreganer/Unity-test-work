using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CreatePrizmC : MonoBehaviour {

	List<Vector3> v = new List<Vector3>();
	List<int> t = new List<int>();
	List<Vector3> a = new List<Vector3>();
	void Start () 
	{

	}

	private void CreateP(bool b)
    {
		string circle = SetCircle.circleText;
		string radius = SetRadius.radiusText;
		string height = ScaleH.heightText;
		if (circle == "" & radius == "" & height == "")
		{
			circle = "6";
			radius = "2";
			height = "1";
		}
		int c = int.Parse(circle);
		int r = int.Parse(radius);
		float h = float.Parse(height);
		if (b)
		{
			t.Clear();
			v.Clear();
			a.Clear();
		}
		for (int i = 0; i < c; i++)
			{
				float y = r * Mathf.Sin(Mathf.Deg2Rad * (360 / ((float)c) * i));
				float x = r * Mathf.Cos(Mathf.Deg2Rad * (360 / ((float)c) * i));
				v.Add(new Vector3(x, h/*высоту задаем через эту переменную*/, y));
				a.Add(new Vector3(x, 0, y));
			}
		if (b)
		{
			for (int l = 0; l < c; l++)
			{
				t.AddRange(new List<int>() { v.Count + 1, v.Count + 2, v.Count }); // бок (рабочее)
				t.AddRange(new List<int>() { a.Count, v.Count + 1, v.Count }); // верх крышка (рабочее)
				v.AddRange(new List<Vector3>() { v[l], v[l + 1], a[l] });
			}
		}
		else
        {
			for (int l = 0; l < c; l++)
			{
				t.AddRange(new List<int>() { v.Count + 2, v.Count + 1, v.Count }); // бок (рабочее)
				v.AddRange(new List<Vector3>() { a[l + 1], v[l + 1], a[l] });
				t.AddRange(new List<int>() { a.Count + 2, v.Count + 2, v.Count + 1 }); // низ крышка (рабочее)
				v.AddRange(new List<Vector3>() { a[l], a[l + 1], a[l] });
			}
		}
		Mesh mesh = GetComponent<MeshFilter>().mesh; ;
		mesh.Clear();
		mesh.vertices = v.ToArray();
		mesh.triangles = t.ToArray();
		mesh.RecalculateNormals();
	}

	public void Create()
	{
		CreateP(true);
		CreateP(false);
	}

	void Update () {
		
	}
}
