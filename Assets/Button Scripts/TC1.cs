using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TC1 : MonoBehaviour {

	public void OnTC1(){

		SceneManager.LoadScene ("Collecting Flowers One", LoadSceneMode.Single);
	}
}
