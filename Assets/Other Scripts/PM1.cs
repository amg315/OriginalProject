using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PM1 : MonoBehaviour {

	public float speed = 5f; //declares speed
	float velX; //Defines movement on X-axis
	float velY; //Defines movement on y-axis
	public float jump = 7f; //how high player will jump
	private Rigidbody2D myRB;
	public bool shooting; //checks to see if player can shoot
	public GameObject bullet; //creates placeholder for object
	Vector2 bulletPos; //creates position for bullet to shoot out of
	public float firing = 5f; //speed at which bullet is fired
	public Transform bulletSpawn; //transforms how bullet will go

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

		//if player hits the s key, it will call the shoot function
		if (Input.GetKeyDown(KeyCode.S)) {
			shooting = true;

			Shoot ();
		}
	}


	void OnCollisionEnter2D(Collision2D other){
		//if the player collides with the flower, the scene transitions

		if (other.gameObject.tag == "flower") {
			SceneManager.LoadScene ("TwoConvoOne", LoadSceneMode.Single);
		}
	}

	void Shoot(){
		//bullet variable is created that takes the bullet object, position and rotation from the GameObject
		var bullet1 = (GameObject)Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		//when the bullet is shot, it moves forward at a speed of 50
		bullet1.GetComponent<Rigidbody2D> ().velocity = bullet1.transform.forward * 50;
		//after 3 seconds, the bullet is destroyed
		Destroy (bullet1, 3f);
	}
}
