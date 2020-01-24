using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demonMove : MonoBehaviour {

	public GameObject bulletPrefab; // var to hold prefab for instantiating bullets

	public float speed = 6f; // the speed that the demon will move at
	float leftRightEdges = 15f; // distance before the demon changes direction

	float chanceDirectionChange = 0.05f; // how likely demon will change direction

	public float secsBetweenLaunch = 3f; //seconds for enemy to launch a new bullet




	void Start () {
		//calls for "Shooting" function to start two seconds after the game starts, then keeps repeating every 3 seconds
		InvokeRepeating ("Shooting", 2f, secsBetweenLaunch);
	}

	// move the ship and randomly change direction while game is running
	void Update () {

		Vector3 pos = transform.position; // create a var to hold current position
		pos.x += speed * Time.deltaTime; // sets the xpos of demon to the speed var * sec since last frame
		transform.position = pos;

		if (pos.x < -leftRightEdges) { // if the demon pos is less than -10 set speed to a pos number
			speed = Mathf.Abs (speed); 
		} else if (pos.x > leftRightEdges) {

			speed = -Mathf.Abs (speed);  // if the demon pos x is greater than 10 reverse speed
		}

	}

	void FixedUpdate(){

		if (Random.value < chanceDirectionChange) {  // change direction at a random interval
			speed *= -1;

		}

	}

	void OnCollisionEnter2D(Collision2D other){
		//if the demon collides with a bullet, the demon will be destroyed
		if (other.gameObject.tag == "bullet"){
			Destroy (this.gameObject);
	}

		

}

	void Shooting(){

		GameObject orb = Instantiate (bulletPrefab) as GameObject; // create reference to hold game object
		orb.transform.position = transform.position; //creates position for bullet to shoot
		Destroy (orb, 1.5f); //destroys bullet after 1.5 seconds

	}

}
