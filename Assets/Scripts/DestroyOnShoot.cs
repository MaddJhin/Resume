using UnityEngine;
using System.Collections;

public class DestroyOnShoot : MonoBehaviour {

	void OnTriggerEnter(Collider other) {

		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
