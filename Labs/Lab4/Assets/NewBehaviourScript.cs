using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class NewBehaviourScript : MonoBehaviour {

	Rigidbody rb;

	public float angle = 30f;
	public float initialVelocity;
	public float velocity;
	
	private float acceleration;
	private float gravity = -9.8f;
	private float distance = 10f;
	private float friction;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		Calculate ();
		rb.AddForce (Vector3.left * initialVelocity);
	}

	void FixedUpdate()
	{
		//velocity = (transform.position.x - lastPosition.x) / Time.deltaTime;
		//rb.AddForce (Vector3.left * initialVelocity);
		//Debug.Log (rb.velocity.normalized.x);
		//rb.velocity = initialVelocity;
	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "Hole")
			acceleration = 0;
	}

	void Calculate()
	{
		friction = rb.mass * gravity * Mathf.Cos (Mathf.Rad2Deg * angle) * 0.6f;
		acceleration = gravity * (Mathf.Sin (Mathf.Rad2Deg * angle)) + friction * rb.mass;
		Debug.Log (acceleration);
		initialVelocity = Mathf.Sqrt (2 * acceleration * distance);
		Debug.Log (initialVelocity);
	}
}
