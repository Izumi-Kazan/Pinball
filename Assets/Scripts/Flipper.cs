using UnityEngine;
using System.Collections;


public class Flipper : MonoBehaviour
{
	public float pressPos = 45f;
	public float power = 10F;
	public KeyCode keyCode;
	
	private bool isFlipup;
	
	void Start() {
		isFlipup = false;
		GetComponent<HingeJoint>().useSpring = true;
		JointSpring js = GetComponent<HingeJoint>().spring;
		js.spring = power;
		js.damper = 0;
		GetComponent<HingeJoint>().spring = js;
	}
	
	void Update () {
		JointSpring js = GetComponent<HingeJoint>().spring;
		if (Input.GetKey(keyCode) || isFlipup) {
			js.targetPosition = pressPos;
		} else {
			js.targetPosition = 0;
		}
		GetComponent<HingeJoint>().spring = js;
	}
		
	public void FlipperUp() {
		isFlipup = true;
	}
	public void FlipperDown() {
		isFlipup = false;
	}
}
