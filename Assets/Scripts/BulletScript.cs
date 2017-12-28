using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    public float shootingForce = 1500f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * shootingForce);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
