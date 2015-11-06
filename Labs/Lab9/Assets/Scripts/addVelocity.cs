using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class addVelocity : MonoBehaviour {

    public float thrust;

    private Rigidbody rb;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.right * thrust);
    }

    void FixedUpdate()
    {
        Debug.Log("Small Sphere:" + rb.velocity);
    }
}
