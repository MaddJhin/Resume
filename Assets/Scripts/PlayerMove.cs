using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public float maxSpeed;
	public Vector3 jumpForce;

	bool grounded;
	// Use this for initialization
	void Update () {
	
//		if (grounded && Input.GetKeyDown (KeyCode.Space))
//		{
//			rigidbody.AddForce (jumpForce, ForceMode.VelocityChange);
//		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		rigidbody.velocity = new Vector3 (0f, Input.GetAxis("Vertical") * speed, 0f);

//		if (rigidbody.velocity.magnitude < maxSpeed)
//		{
//			rigidbody.AddForce (0f, Input.GetAxis("Vertical") * speed, 0f, ForceMode.Acceleration);
//		}

	}

	void OnCollisionEnter () {
		grounded = true;
	}

	void OnCollisionExit () {
		grounded = false;
	}
}
