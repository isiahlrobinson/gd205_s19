using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 playerPos;
    public Transform destination;
    public Transform hazard;
    Vector3 startPos;
    public TextMesh playerMessage;

    // Use this for initialization
    void Start()
    {
        playerPos = transform.position;
        startPos = playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        // Player Movement with keys
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerPos += transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerPos += transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerPos -= transform.right;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerPos -= transform.forward;
        }

        //     if (playerPos.x == destination.position.x && 
        //        playerPos.z == destination.position.z){
        //       playerPos += transform.up;
    }
    // hazard spot that will restart character
    //  if(playerPos.x == hazard.position.x &&
    //  playerPos.z == hazard.position.z){
    // playerPos -= transform.up; 

    // Resets player position to start position
    //  playerPos = startPos;
    // TextMesh = "you suck";
}
      //  transform.position = playerPos;
