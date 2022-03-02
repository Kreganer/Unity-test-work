using UnityEngine;
using System.Collections;
using System.Globalization;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class Test : MonoBehaviour
{
	void Start()
	{
		CreateCube();
	}

	private void CreateCube()
	{
		string length = ScaleL.lengthText;
		string width = ScaleW.widthText;
		string height = ScaleH.heightText;
		if (length == null & width == null & height == null)
		{
			length = "1";
			width = "1";
			height = "1";
		}
		int l = int.Parse(length);
		int w = int.Parse(width);
		int h = int.Parse(height);

		Vector3[] vertices = {
			new Vector3 (0, 0, 0),
			new Vector3 (l, 0, 0),
			new Vector3 (l, h, 0),
			new Vector3 (0, h, 0),
			new Vector3 (0, h, w),
			new Vector3 (l, h, w),
			new Vector3 (l, 0, w),
			new Vector3 (0, 0, w),
		};

		/*for (int i = 0; i < vertices.Length; i++)
		{
			vertices[i].Scale(size);
		}*/


		int[] triangles = {
			0, 2, 1, //face front
			0, 3, 2,
			2, 3, 4, //face top
			2, 4, 5,
			1, 2, 5, //face right
			1, 5, 6,
			0, 7, 4, //face left
			0, 4, 3,
			5, 4, 7, //face back
			5, 7, 6,
			0, 6, 7, //face bottom
			0, 1, 6
		};

		Mesh mesh = GetComponent<MeshFilter>().mesh;
		mesh.Clear();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.RecalculateNormals();
	}

	public void Create()
    {
		CreateCube();
	}

	 public void Update()
	{

	}
}
