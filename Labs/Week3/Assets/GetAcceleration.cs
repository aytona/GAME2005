using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class GetAcceleration : MonoBehaviour {

	private Vector3 lastPosition;
	private float Velocity = 0;
	private float Acceleration = 0;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		Velocity = (transform.position.z - lastPosition.z) / Time.deltaTime;
		lastPosition.z = transform.position.z;
		Acceleration = Velocity / Time.deltaTime;

		Debug.Log (Acceleration);
		//Debug.Log (Velocity);
		//Debug.Log (rb.velocity.z);
	}
}
