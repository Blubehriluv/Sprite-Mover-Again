using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform tf;
    public float xAngle, yAngle, zAngle;
    public float speed;

	// Use this for initialization
	void Start () {
		tf = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (Input.GetKey(KeyCode.W))
	    {
	        tf.position = tf.position + Vector3.up * speed;
        }

	    if (Input.GetKey(KeyCode.A))
	    {
	        tf.position = tf.position + Vector3.left * speed;
	    }

	    if (Input.GetKey(KeyCode.S))
	    {
	        tf.position = tf.position + Vector3.down * speed;
	    }

	    if (Input.GetKey(KeyCode.D))
	    {
	        tf.position = tf.position + Vector3.right * speed;
	    }

    }
}
