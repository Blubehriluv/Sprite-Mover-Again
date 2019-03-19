using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDisable : MonoBehaviour {

    public PlayerController playerStop;

    // Use this for initialization
    void Start ()
    {
	    playerStop = GetComponent<PlayerController>();
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.P))
	    {
	        playerStop.enabled = !playerStop.enabled;
	    }
    }
}
