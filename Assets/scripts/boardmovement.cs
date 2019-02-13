using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boardmovement : MonoBehaviour {

    public float gridSize = 1f;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log("im here");
        transform.position += transform.forward * gridSize;
    }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("im here");
            transform.position += -transform.right * gridSize;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("im here");
            transform.position += -transform.forward * gridSize;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("im here");
            transform.position += transform.right * gridSize;
        }


    }
}
