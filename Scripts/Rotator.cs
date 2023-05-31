using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 200.0f;
    public float x = 0f;
    public float y = 0f;
    public float z = 0f;

    void Update()
    {

        transform.Rotate(rotationSpeed * Time.deltaTime * x,
                        rotationSpeed * Time.deltaTime * y, 
                        rotationSpeed * Time.deltaTime * z);


    }
}
