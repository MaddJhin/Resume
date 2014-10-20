using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float speed;
	public float maxSpeed;
	public Vector3 jumpForce;

	bool grounded;
	// Use this for initialization
	void Update () {
	
		if (grounded && Input.GetKeyDown (KeyCode.Space))
		{
			rigidbody.AddForce (jumpForce, ForceMode.VelocityChange);
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (rigidbody.velocity.magnitude < maxSpeed)
			{
				rigidbody.AddForce (Input.GetAxis("Horizontal") * speed, 0f, 0f, ForceMode.Acceleration);
			}


//		if (rigidbody.velocity.magnitude < maxSpeed)
//		{
//			rigidbody.AddForce (Input.GetAxis("Horizontal") * speed, 0f, 0f);
//		}
//
//		if (Input.GetKeyDown (KeyCode.Space))
//		{
//			rigidbody.velocity = rigidbody.velocity + (Vector3.up * jumpForce);
//		}

	}

	void OnCollisionEnter () {
		grounded = true;
	}

	void OnCollisionExit () {
		grounded = false;
	}
}
