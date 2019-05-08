using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaloPoints : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player1")
        {
            KeepScore.Score += 100;
            Destroy(gameObject);


        }
    }


}
