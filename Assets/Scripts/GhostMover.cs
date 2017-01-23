using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMover : MonoBehaviour {

	//public float speed = 5f;

	private Vector3 direction = new Vector3(Random.Range(-3,3),0,Random.Range(-3,3));



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		transform.Translate(direction * Time.deltaTime); 

		//transform.localPosition += transform.forward * speed * Time.deltaTime;
		/*
		Vector3 motion = new Vector3 (transform.position.x + 0.1f, transform.position.y, transform.position.z);
		Debug.Log (transform.position.x);
		transform.Translate (motion * Time.deltaTime);
		*/
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Wall")) {
			
			direction.x *= (-1*(Random.Range(0.5f,1.5f)));
			direction.z *= (-1*(Random.Range(0.5f,1.5f)));
		
		}
	}
}
