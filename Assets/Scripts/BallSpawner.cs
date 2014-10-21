using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

	public float timeBetweenSpawn;
	public Transform ball;

	Ray spawnRay;
	RaycastHit spawnHit;
	int shootableMask;
	float timer;


	// Use this for initialization
	void Awake () {

		shootableMask = LayerMask.GetMask ("Shootable");


	}
	
	void Update () {

		spawnRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		timer += Time.deltaTime;
	
		if (Input.GetButton ("Fire1") && timer >= timeBetweenSpawn)
		{
			SpawnBall ();
		}
	}

	void SpawnBall () {

		timer = 0f;

		if(Physics.Raycast (spawnRay, out spawnHit, Mathf.Infinity, shootableMask))
		{
			Instantiate (ball, spawnHit.point, Quaternion.identity);
		}
	
	}
}
