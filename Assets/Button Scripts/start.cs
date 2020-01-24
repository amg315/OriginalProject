using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour {

	//when the player hits the button, the scene will transition.
	public void OnStart(){

		SceneManager.LoadScene ("Dialogue One", LoadSceneMode.Single);
	}
}
