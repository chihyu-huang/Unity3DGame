using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorZ : MonoBehaviour
{
    public float rotationSpeed = 200.0f;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its Y axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
