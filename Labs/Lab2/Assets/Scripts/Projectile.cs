using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	
	public float gravity = 10f;
	public float speed = 20f;
	public Transform red;

	void Update()
	{
		float x = transform.position.x;
		if(x <= red.transform.position.x)
			transform.position = new Vector3 (speed * Time.time, -.5f * gravity * Mathf.Pow (Time.time, 2) + speed * Mathf.Sin ((Mathf.PI * 60) / 180) * Time.time, 0);
	}
}
