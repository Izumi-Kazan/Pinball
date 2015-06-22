using UnityEngine;
using System.Collections;

public class BallSpeed : MonoBehaviour {
	
	public float maxVelocity = 30f;

	private float maxSqrVelocity;
	
	void Start () {
		maxSqrVelocity = maxVelocity * maxVelocity;
	}
	
	void FixedUpdate () {
		if (GetComponent<Rigidbody>().velocity.sqrMagnitude > maxSqrVelocity) {
			GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * maxVelocity;
		}
	}
}
