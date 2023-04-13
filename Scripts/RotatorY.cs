using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorY : MonoBehaviour
{
    public float rotationSpeed = 200.0f;

    void Update()
    {
        // Rotate the object around its Y axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
