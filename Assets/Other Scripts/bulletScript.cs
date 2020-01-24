using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bulletScript : MonoBehaviour {

	public float velX = 5f; //speed of bullet along the x-axis
	private Rigidbody2D bulletrb; //rigidbody of bullet
	public bool hitDemon; //checks to see if demon is hit

	// Use this for initialization
	void Start () {

		bulletrb = GetComponent<Rigidbody2D> (); //Initializes Rigidbody2D for bullet
		
	}
	
	// Update is called once per frame
	void Update () {

		bulletrb.velocity = new Vector2 (velX, bulletrb.velocity.y); //movement of the bullet moves at a speed of 5 along the x-axis while keeping the same y-position

		
	}

	void OnCollisionEnter2D(Collision2D other){

		//if the bullet hits a gameObject called Demon1, the boolean is true and the object is destroyed. The scene transitions.
		if (other.gameObject.name == "Demon1") {
			hitDemon = true;
			Destroy (other.gameObject);
			SceneManager.LoadScene ("Get Flower", LoadSceneMode.Single);
		}

		//if the bullet hits the demon bullets that are tagged as the following (different scenes), those bullets are destroyed while the player's bullet stays in the game
		if (other.gameObject.tag == "evilb") {

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "evil2") {

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "D2") {

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "demon1"){
			hitDemon = true;
			Destroy(other.gameObject);
		}
	}
}
