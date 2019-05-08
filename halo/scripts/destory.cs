using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destory : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player1")
        {
       //This line of code destorys the player when it touches the game object
            Destroy(collision.gameObject);


        }
    }


}
