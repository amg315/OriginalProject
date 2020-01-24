using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour {

	public float speed = 5f; //declares speed
	float velX; //Defines movement on X-axis
	float velY; //Defines movement on y-axis
	public float jump = 15f; //how high player can jump in the air
	private Rigidbody2D myRB;

	// Use this for initialization
	void Start () {

		myRB = GetComponent<Rigidbody2D> (); //lets us use the Rigidbody of the player

	}

	// Update is called once per frame
	//code used: https://www.youtube.com/watch?v=Nmx4yP-aWPw
	void Update () {

		//This helps us to get our movement defined on the horizontal axis and the movement of the player
		//is their movement on the x-axis while keeping the same position on the y-axis
		velX = Input.GetAxisRaw ("Horizontal");
		velY = myRB.velocity.y;
		myRB.velocity = new Vector2 (velX * speed, velY);

		//code: https://www.youtube.com/watch?v=i363lrvWqcY
		if (Input.GetKeyDown (KeyCode.Space)) {

			myRB.velocity = new Vector2 (myRB.velocity.x, jump);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		//if the player collides with the door, they will go to a new level
		if (other.gameObject.tag == "door") {
			SceneManager.LoadScene ("Convo One", LoadSceneMode.Single);
		}
	}
}
