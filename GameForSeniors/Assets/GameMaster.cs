﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;


    // Use this for initialization  
    void Start()
    {
        if (gm = null)
        {
           // gm = GameObject.FindGameObjectWithTag("GM");
        }
    }
    public static void KillPlayer(BirdPlayer birdPlayer)
    {
        Destroy(birdPlayer.gameObject);
    }
		
	
	
	
}
