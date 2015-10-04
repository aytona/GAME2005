using UnityEngine;
using System.Collections;

public class ConstantSpeed : MonoBehaviour {

	public float speed = 20f;
	public Transform red;

	void Update()
	{
		float x = transform.position.x;
		if (x <= red.transform.position.x)
			transform.position = new Vector3 (speed * Time.time,0,0);
	}
}
