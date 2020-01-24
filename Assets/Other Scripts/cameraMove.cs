using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {

	private Vector3 offset; 
	public GameObject player; //identifies the player will be an object the camera follows

	// Use this for initialization
	void Start () {
		//offset is the position of the camera away from the player's position so it's not too close
		offset = transform.position - player.transform.position;

	}

	// Update is called once per frame
	void LateUpdate(){
		//if the player moves past -10.1 on the horizontal axis, the camera now follows the player's position 0.2
		//points ahead of them while keeping the same distance away from them
		if (player.transform.position.x > -9.06f) {

			transform.position = player.transform.position + 0.2f * offset;
		}

	}
}
