using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CreateSphere : MonoBehaviour {

	List<Vector3> v = new List<Vector3>();
	List<Vector3> v1 = new List<Vector3>();
	List<Vector3> n = new List<Vector3>();
	List<int> t = new List<int>();
	List<Vector3> a = new List<Vector3>();
	bool miror = false;
	// Use this for initialization
	void Start () {
		
	}

	private void CreateP()
	{
		string circle = SetCircle.circleText;
		string radius = SetRadius.radiusText;
		if (circle == "" & radius == "")
		{
			circle = "24";
			radius = "1";
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
			t.Clear();
			v.Clear();
			v1.Clear();
			a.Clear();
			int i = 0;
			while (i <= c)
			{
				float y = r * Mathf.Sin(Mathf.Deg2Rad * (360 / ((float)c) * i));
				float x = r * Mathf.Cos(Mathf.Deg2Rad * (360 / ((float)c) * i));
				v.Add(new Vector3(x, 0, y));
				a.Add(new Vector3(x, y, 0));
				i++;
			}

			int p = 0;
			while (p <= c / 4)
			{
				int v1p = 0;
				while (v1p <= c)
				{
					float z1 = v[p].z;
					float y1 = v[p].x;
					float y = y1 * Mathf.Sin(Mathf.Deg2Rad * (360 / ((float)c) * v1p));
					float x = y1 * Mathf.Cos(Mathf.Deg2Rad * (360 / ((float)c) * v1p));
					v1.Add(new Vector3(x, z1, y));
					v1p++;
				}
			 p++;
			}

			for (int l = 0; l <= ( ( c / 4 ) * c ) + (( c / 4 ) - 2); l++)
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
		mesh.normals = n.ToArray();
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
	void Update()
	{
		
	}
}
