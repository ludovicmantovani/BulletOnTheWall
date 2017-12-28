using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float shootingForce = 1500f;
	public Vector3 shootingDirection;
	public float lifetime = 3f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
	}

	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (gameObject);
		}
	}
}
