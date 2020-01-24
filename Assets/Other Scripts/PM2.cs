using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PM2 : MonoBehaviour {

	public float speed = 5f; //declares speed
	float velX; //Defines movement on X-axis
	float velY; //Defines movement on y-axis
	public float jump = 11f; //how high the player will jump
	private Rigidbody2D myRB;
	public bool shooting;//checks if player hits the s key to shoot
	public GameObject bullet;//creates new gameObject for bullet
	Vector2 bulletPos;//creates new position for the bullet
	public float firing = 5f;//speed at which bullet is fired
	public Transform bulletSpawn;
	public Text flowerText;//creates text that holds score for how many flowers the player gets
	public int flowers = 0; //amount of flowers player collects
	public AudioClip grunt;//grunt for when player dies
	public AudioClip point;//sound that plays when player collects a flower
	private AudioSource myAudio;

	// Use this for initialization
	void Start () {

		myRB = GetComponent<Rigidbody2D> (); //lets us use the Rigidbody of the player
		myAudio = GetComponent<AudioSource>(); //initializes the audio source needed to have the sounds played

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

		if (Input.GetKeyDown(KeyCode.S)) {
			shooting = true;

			Shoot ();
		}
		//if the player hits the R key, they will restart the game
		if (Input.GetKeyDown (KeyCode.R)) {

			SceneManager.LoadScene ("Collecting Flowers One");
		}
			
	}


	void OnCollisionEnter2D(Collision2D other){
		//if the player collides with the door, they will go to a new level
		if (other.gameObject.tag == "door") {
			SceneManager.LoadScene ("Convo One", LoadSceneMode.Single);
		}
		//if the player collides with a flower, a point will be added to their score and an audio sound will play. Once the player gets 2 flowers, the scene transitions
		if (other.gameObject.tag == "flowerone") {
			flowers++;
			myAudio.PlayOneShot (point);
			Destroy (other.gameObject);
			flowerText.text = "Flowers: " + flowers.ToString ();
			if (flowers == 2) {

				SceneManager.LoadScene ("Three Convo One", LoadSceneMode.Single);
			}
			
		}

		if (other.gameObject.tag == "flower2") {

			flowers++;
			myAudio.PlayOneShot (point);
			Destroy (other.gameObject);
			flowerText.text = "Flowers: " + flowers.ToString ();
			if (flowers == 2) {

				SceneManager.LoadScene ("Four Convo One", LoadSceneMode.Single);
			}
		}

			if (other.gameObject.tag == "f3") {

				flowers++;
			myAudio.PlayOneShot (point);
				Destroy (other.gameObject);
				flowerText.text = "Flowers: " + flowers.ToString ();
				if (flowers == 2) {

					SceneManager.LoadScene ("Five Convo One", LoadSceneMode.Single);
				}
			}

		if (other.gameObject.tag == "finalf") {

			SceneManager.LoadScene ("Final Convo", LoadSceneMode.Single);
		}
		//if player collides with bullets of any of these tags, the grunt sound plays and the level is restarted
		if (other.gameObject.tag == "evilb") {
			myAudio.PlayOneShot (grunt);
			SceneManager.LoadScene ("Collecting Flowers One", LoadSceneMode.Single);
		}

		if (other.gameObject.tag == "evil2") {
			myAudio.PlayOneShot (grunt);
			SceneManager.LoadScene ("CollectThreeFlowers", LoadSceneMode.Single);
		}

		if (other.gameObject.tag == "evilb3") {
			myAudio.PlayOneShot (grunt);
			SceneManager.LoadScene ("Level Three", LoadSceneMode.Single);
		}

		if (other.gameObject.tag == "finalb") {
			myAudio.PlayOneShot (grunt);
			SceneManager.LoadScene ("Final Level", LoadSceneMode.Single);
		}
	}

	void Shoot(){
		var bullet1 = (GameObject)Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation);
		bullet1.GetComponent<Rigidbody2D> ().velocity = bullet1.transform.forward * 50;
		Destroy (bullet1, 3f);
	}
}
