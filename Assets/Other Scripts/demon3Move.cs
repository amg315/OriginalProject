using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demon3Move : MonoBehaviour {

	public GameObject bulletPrefab; // var to hold prefab for instantiating orbs

	public float speed = 6f; // speed ship is moving
	float leftRightEdges = 100f; // distance before the ship changes direction

	float chanceDirectionChange = 0.05f; // how likely ship will change direction

	public float secsBetweenLaunch = 3f;



	// on start we want orbs to start falling from the ship
	void Start () {

		InvokeRepeating ("Shooting", 2f, secsBetweenLaunch);
	}

	// move the ship and randomly change direction while game is running
	void Update () {

		Vector3 pos = transform.position; // create a var to hold current position
		pos.x += speed * Time.deltaTime; // sets the xpos of our ship to the speed var * sec since last frame
		transform.position = pos;

		if (pos.x < -leftRightEdges) { // if the ship pos is less than -10 set speed to a pos number
			speed = Mathf.Abs (speed); 
		} else if (pos.x > leftRightEdges) {

			speed = -Mathf.Abs (speed);  // if the ship pos x is greater than 10 reverse speed
		}

	}

	void FixedUpdate(){

		if (Random.value < chanceDirectionChange) {  // change direction at a random interval
			speed *= -1;

		}

	}

	void OnCollisionEnter2D(Collision2D other){
		//if the player collides with the door, they will go to a new level
		if (other.gameObject.tag == "bullet"){
			Destroy (this.gameObject);
		}



	}

	void Shooting(){

		GameObject orb = Instantiate (bulletPrefab) as GameObject; // create reference to hold game object
		orb.transform.position = transform.position;
		Destroy (orb, 3.2f);

	}

}
