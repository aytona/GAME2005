using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class RotateAround : MonoBehaviour {

	Rigidbody rb;
	public float Degrees;
	public Vector3 Velocity;

	private bool keyPressed = false;
	private Vector3 previous;
	private bool ForceAdded = false;

	void Awake()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update ()
	{
		if (Input.GetKey (KeyCode.F))
			keyPressed = true;
	}

	void FixedUpdate()
	{
		Velocity = (transform.position - previous) / Time.deltaTime;
		previous = transform.position;
		if (!keyPressed)
			transform.RotateAround (Vector3.zero, Vector3.up, Degrees * Time.deltaTime);
		if (keyPressed) {
			AddForce ();
			Debug.Log (rb.velocity.magnitude);
		}
	}

	void AddForce()
	{
		if (!ForceAdded) {
			rb.AddForce (Velocity * (Degrees/2));
			ForceAdded = true;
		}
	}
}