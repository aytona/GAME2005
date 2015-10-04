using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {
	
	public float gravity = 10f;
	public float speed = 20f;

	void Update()
	{
		if(transform.position.y >= 0)
			transform.position = new Vector3 (70,-.5f * gravity * Mathf.Pow (Time.time, 2) + speed * Mathf.Sin ((Mathf.PI * 60) / 180) * Time.time, 0);
	}
}
