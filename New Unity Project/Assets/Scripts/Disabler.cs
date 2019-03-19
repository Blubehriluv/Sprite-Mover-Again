using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disabler : MonoBehaviour
{
    private Vector3 original;

	// Use this for initialization
	void Start ()
	{
	    //original = gameObject.transform.position;
	    original = new Vector3(0, 0, -1);
    }
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(KeyCode.Space))
	    {
	        transform.position = original;
        }


	    if (Input.GetKey(KeyCode.P))
	    {
	        //GetComponent(CameraController).enabled = false;

        }
    }
}
