using UnityEngine;
using System.Collections;

public class HazardMove : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update () {
		rigidbody.velocity = -transform.right * speed;

	}
}
