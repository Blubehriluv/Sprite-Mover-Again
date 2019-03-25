using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDisable : MonoBehaviour {

    public CameraController camStop;

    // Use this for initialization
    void Start ()
    {
	    camStop = GetComponent<CameraController>();
    }
	
	// Update is called once per frame
	void Update ()
	{
        //The movement of the camera will disable when the player movement disables
	    if (Input.GetKeyDown(KeyCode.P))
	    {
	        camStop.enabled = !camStop.enabled;
	    }
    }
}
