using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class readVelocity : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate()
    {
        Debug.Log("Big Sphere: " + rb.velocity);
    }
}
