using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public AudioClip coinSound;

    GameManager gm;

    AudioSource audio;
    Animator anim;
    Rigidbody rb;
    Vector3 inputVector;

    // Start is called before the first frame update
    void Start()
    {
        //referencing the Rigigbody
        rb = GetComponent<Rigidbody>();
        //referencing the GameManager
        gm = FindObjectOfType<GameManager>();

        //referencing the Animator
        anim = GetComponentInChildren<Animator>();

        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    //Function to controll player movement
    private void PlayerMovement()
    {
        //Gettng horizontal input
        float h = Input.GetAxisRaw("Horizontal");

        //getting vertical input
        float v = Input.GetAxisRaw("Vertical");

        //Setting animation bool
        if (h != 0 || v != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        //Calculating Input
        inputVector = new Vector3(h, rb.velocity.y, v);

        var mainCam = Camera.main;
        inputVector = mainCam.transform.TransformDirection(inputVector);
        inputVector.y = 0f;
        inputVector.Normalize();
        //Making the player face the input direction
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
        //setting the velocity to the canculated input
        rb.velocity = inputVector * moveSpeed;
    }

    //OnTriggerEnter Function
    void OnTriggerEnter(Collider other)
    {
        //Detect if coin is being picked
        if (other.gameObject.CompareTag("Coin"))
        {
            //Add Score in GameManager when picking up coin
            gm.score += 100f;
            //Play Coin Sound
            audio.PlayOneShot(coinSound);
            //Destroy Coin
            Destroy(other.gameObject);
        }

        //Detect if maze end is reached
        if (other.gameObject.CompareTag("Exit"))
        {
            gm.isGameOver = true;
        }
    }
}
