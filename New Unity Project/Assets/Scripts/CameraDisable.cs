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
	    if (Input.GetKeyDown(KeyCode.P))
	    {
	        camStop.enabled = !camStop.enabled;
	    }
    }
}
