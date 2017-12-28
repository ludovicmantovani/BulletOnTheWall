using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour {

	public GameObject[] explosionParticlePrefabs;
	public int amountOfParticles = 3;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < amountOfParticles; i++) {
			GameObject explosionParticlePrefab = Instantiate (explosionParticlePrefabs [Random.Range (0, explosionParticlePrefabs.Length)]);
			explosionParticlePrefab.transform.position = transform.position;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
