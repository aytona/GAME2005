using UnityEngine;
using System.Collections;

public class Wind : MonoBehaviour {

	public float WindPower;

	void OnTriggerStay(Collider other)
	{
		other.GetComponent<Rigidbody> ().AddForce (Vector3.forward * WindPower);
	}
}
