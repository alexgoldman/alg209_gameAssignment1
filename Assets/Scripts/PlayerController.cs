using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float speed;
	public Rigidbody pacman;
	public Text scoreText;
	private int score;
	public Text healthText;
	private int health;

	// Use this for initialization
	void Start () {
		pacman = GetComponent<Rigidbody> ();
		score = 0;
		health = 3;
		SetScoreText ();
		SetHealthText ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");



		Vector3 move = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		pacman.AddForce (move * speed);
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive (false);
			score++;
			SetScoreText ();
		} else if (other.gameObject.CompareTag ("Ghost")) {
			health--;
			SetHealthText ();
		}
	}

	/*
	void OnTrigger(Collider other){
		if(other.gameObject.CompareTag("Ghost")){
			health--;
			SetHealthText ();
		}
	}*/


	void SetScoreText (){
		scoreText.text = "Score: " + score.ToString ();
	}

	void SetHealthText (){
		healthText.text = "Health: " + health.ToString ();
	}
}
