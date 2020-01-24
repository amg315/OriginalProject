using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D1 : MonoBehaviour {

	public void OnD1(){

		SceneManager.LoadScene ("Dialogue Two", LoadSceneMode.Single);
	}
}
