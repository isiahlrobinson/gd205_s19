using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class move : MonoBehaviour {
    Rigidbody myRb;
	// Use this for initialization
	void Start () {

        myRb = GetComponent<Rigidbody>();

		
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRb.AddForce(Vector3.up * 999f);
        }

	}
    
}
