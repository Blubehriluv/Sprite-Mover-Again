using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Boolean up = false;
    private Boolean down = true;
    private Boolean left = false;
    private Boolean right = false;


	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {

        //FOR THE USER TO MOVE UP
	    if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
	    {
	        if (down == true)
	        {
	            transform.Rotate(0, 0, -180);
	            up = true;
	            down = false;
	            left = false;
	            right = false;
	        }
	        if (left == true)
	        {
	            transform.Rotate(0, 0, -90);
	            up = true;
	            down = false;
	            left = false;
	            right = false;
	        }

	        if (right == true)
	        {
	            transform.Rotate(0, 0, 90);
	            up = true;
	            down = false;
	            left = false;
	            right = false;
	        }
        }

        //FOR THE USER TO MOVE DOWN
	    if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
	    {
	        if (up == true)
	        {
                transform.Rotate(0, 0, -180);
	            up = false;
	            down = true;
	            left = false;
	            right = false;
	        }
	        if (left == true)
	        {
	            transform.Rotate(0, 0, 90);
	            up = false;
	            down = true;
	            left = false;
	            right = false;
	        }

	        if (right == true)
	        {
	            up = false;
	            down = true;
	            left = false;
	            right = false;
	            transform.Rotate(0, 0, -90);
	        }

        }

        //FOR THE USER TO MOVE LEFT
	    if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
	    {
	        if (down == true)
	        {
                transform.Rotate(0, 0, -90);
	            up = false;
	            down = false;
	            left = true;
	            right = false;
	        }

	        if (up == true)
	        {
	            transform.Rotate(0, 0, 90);
	            up = false;
	            down = false;
	            left = true;
	            right = false;
	        }

	        if (right == true)
	        {
	            transform.Rotate(0, 0, -180);
	            up = false;
	            down = false;
	            left = true;
	            right = false;
                
	        }
	    }

        //FOR THE USER TO MOVE RIGHT
	    if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
	    {
	        if (down == true)
	        {
	            transform.Rotate(0, 0, 90);
	            up = false;
	            down = false;
	            left = false;
	            right = true;
	        }

	        if (up == true)
	        {
	            transform.Rotate(0, 0, -90);
	            up = false;
	            down = false;
	            left = false;
	            right = true;
	        }

	        if (left == true)
	        {
	            transform.Rotate(0, 0, -180);
	            up = false;
	            down = false;
	            left = false;
	            right = true;
	            
	        }
        }
    }
}
