using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CreateCapsule : MonoBehaviour {

	List<Vector3> v = new List<Vector3>();
	List<Vector3> v1 = new List<Vector3>();
	List<Vector3> v2 = new List<Vector3>();
	List<Vector3> v3 = new List<Vector3>();
	List<Vector3> v4 = new List<Vector3>();
	List<Vector3> v5 = new List<Vector3>();
	List<Vector3> v6 = new List<Vector3>();
	List<Vector3> center = new List<Vector3>();
	List<int> t = new List<int>();
	List<Vector3> a = new List<Vector3>();
	List<Vector3> a1 = new List<Vector3>();
	bool miror = false;
	// Use this for initialization
	void Start () {
		
	}

	private void CreateP()
	{
		string circle = SetCircle.circleText;
		string radius = SetRadius.radiusText;
		string height = ScaleH.heightText;
		if (circle == "" & radius == "" & height == "")
		{
			circle = "20";
			radius = "1";
			height = "1";
		}
		int c = int.Parse(circle);
		if (c >= 24)
        {
			c = 24;
        }
		int r = int.Parse(radius);
		while (c % 4 != 0)
        {
			c = c + 1;
        }
		float h = float.Parse(height)/2;
			t.Clear();
			center.Clear();
			v.Clear();
			v1.Clear();
			v2.Clear();
			v3.Clear();
			v4.Clear();
			v5.Clear();
			v6.Clear();
			a.Clear();
			a1.Clear();
		int n = 0;
		while (n <= r)
		{
			int i = 0;
			while (i <= c & h <= c)
			{
					float y = r * Mathf.Sin(Mathf.Deg2Rad * (360 / ((float)c) * i));
					float x = r * Mathf.Cos(Mathf.Deg2Rad * (360 / ((float)c) * i));
					v.Add(new Vector3(x, h/*высоту задаем через эту переменную*/, y));
					a.Add(new Vector3(x, 0, y));
					a1.Add(new Vector3(x, y + h, 0));
				i++;
			}
			int p = 0;
			while (p <= c / 4)
			{
				int v1p = 0;
				while (v1p <= c)
				{
					float z1 = a1[p].y;
					float y1 = a1[p].x;
					float y = y1 * Mathf.Sin(Mathf.Deg2Rad * (360 / ((float)c) * v1p));
					float x = y1 * Mathf.Cos(Mathf.Deg2Rad * (360 / ((float)c) * v1p));
					v1.Add(new Vector3(x, z1, y));
					v1p++;
				}
				p++;
			}
			h = h + h;
			n++;
		}

			for (int l = 0; l < c; l++)
			{
				t.AddRange(new List<int>() { v.Count + 1, v.Count + 2, v.Count }); // бок (рабочее)
				v.AddRange(new List<Vector3>() { v[l], v[l + 1], a[l] });
			}
			for (int l = 0; l < c; l++)
			{
				t.AddRange(new List<int>() { v.Count + 2, v.Count + 1, v.Count }); // бок (рабочее)
				v.AddRange(new List<Vector3>() { a[l + 1], v[l + 1], a[l] });
			}

			for (int l = 0; l <= ((c / 4) * c) + ((c / 4) - 2); l++)
			{
				t.AddRange(new List<int>() { v.Count, v.Count + 1, v.Count + 2 });
				v.AddRange(new List<Vector3>() { v1[l], v1[l + (c + 1)], v1[l + 1] });
				t.AddRange(new List<int>() { v.Count, v.Count + 1, v.Count + 2 });
				v.AddRange(new List<Vector3>() { v1[l], v1[l + c], v1[l + (c + 1)] });
			}
		
		Mesh mesh = GetComponent<MeshFilter>().mesh; ;
		mesh.Clear();
		mesh.vertices = v.ToArray();
		mesh.triangles = t.ToArray();
		if (miror == false)
        {
			var Clone = Instantiate(this.gameObject, new Vector3(0, 0, 0), Quaternion.AngleAxis(180, Vector3.forward));
			miror = true;
		}
		mesh.RecalculateNormals();
	}

	public void Create()
	{
		CreateP();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
