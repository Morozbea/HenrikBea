﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGameButton()
    {
        SceneManager.LoadScene("Question1");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    }
}
