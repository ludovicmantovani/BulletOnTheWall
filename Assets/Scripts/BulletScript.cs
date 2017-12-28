using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float shootingForce = 1500f;
	public Vector3 shootingDirection;
	public float lifetime = 3f;
	public GameObject explosionPrefab;

	private GameObject explosionObject;
	private bool canExplose = true;

	void Start () {
		GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
	}

	void Update () {
		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (gameObject);
			Destroy (explosionObject);
		}
	}

	void OnCollisionEnter(Collision collision) {
		if (canExplose && collision.transform.tag == "TriggerExplosion") {
			canExplose = false;
			explosionObject = Instantiate (explosionPrefab);
			explosionObject.transform.position = transform.position;
		}
	}

}
