﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene("Scene1");

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame() {
        SceneManager.LoadScene("Scene 2");
    }
}
