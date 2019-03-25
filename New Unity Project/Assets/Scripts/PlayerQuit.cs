using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerQuit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Allows the player to quit the game
	    if (Input.GetKey(KeyCode.Escape))
	    {
	        Application.Quit();
	    }
	}
}
