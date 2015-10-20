using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

	Rigidbody objectMass;

	public float constant;
	public float compression;

	private float horizontalAngle = 45f;
	private float verticalAngle = 90f;
	private float mass;

	void Start()
	{
		objectMass = GetComponent<Rigidbody> ();
		mass = objectMass.mass;
		Vector3 angleVector = new Vector3 (Mathf.Cos(horizontalAngle), Mathf.Sin(verticalAngle), 0.0f);
		angleVector.Normalize ();
		Vector3 springVelocity = angleVector * (compression * Mathf.Sqrt (constant / mass));
		objectMass.AddForce (springVelocity);
	}
}