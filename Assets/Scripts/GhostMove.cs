using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostMove : MonoBehaviour {
	public float moveSpeed = 3f;
	public Rigidbody ghost;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {


	}
		

	/*void OnCollisionEnter (hit Collision){

		var tag = hit.ghost.tag; 
		if (tag == "Wall")
			direction.x *= -1;
	}
	*/
}
