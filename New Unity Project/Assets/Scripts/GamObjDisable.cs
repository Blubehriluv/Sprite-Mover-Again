﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamObjDisable : MonoBehaviour
{

    public GameObject noPlay;

	// Use this for initialization
	void Start ()
	{
	   
	}
	
	// Update is called once per frame
	void Update () {
     
	    if (Input.GetKeyDown(KeyCode.Q))
	    {
	       
            noPlay.SetActive(false);
        }
    }
}
