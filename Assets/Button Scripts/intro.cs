﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour {

	public void OnIntro(){

		SceneManager.LoadScene ("Tutorial", LoadSceneMode.Single);
	}
}
