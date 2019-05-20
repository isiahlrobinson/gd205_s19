using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float coinRotationSpeed = 100f;

    void FixedUpdate()
    {
        transform.Rotate(0, -coinRotationSpeed * Time.deltaTime, 0);
    }
}
