﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

	public void OnEnd(){

		SceneManager.LoadScene ("Goodbye", LoadSceneMode.Single);
	}
}
