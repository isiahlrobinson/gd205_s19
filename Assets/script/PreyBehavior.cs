using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyBehavior : MonoBehaviour
{


    Rigidbody preyRB;
    public Transform pred;
    public float forceAmt;

    // Use this for initialization
    void Start()
    {
        preyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 predDirection = Vector3.Normalize(transform.position - pred.position);
        preyRB.AddForce(predDirection * forceAmt);
    }
    private void OnCollisionEnter(Collision col)
   {
   // this destroys game object on collision
       if (col.transform == pred)
        {
            // Destroy(this.gameObject);
            gameObject.GetComponent<Renderer>().material.color = Color.red;
       }
      /*  if (col.gameObject.CompareTag("prey"))
        {
            Destroy (col.gameObject);
        }*/
    }
} 