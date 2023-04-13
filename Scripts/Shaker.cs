using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    // public float shakeMagnitude = 0.1f;
    // public float shakeDuration = 0.5f;
    // public float shakeSpeed = 10.0f;
    // public float tiltAngle = 10.0f;

    // private Vector3 originalPosition;
    // private Quaternion originalRotation;
    // private float shakeTimer = 0.0f;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     // Store the object's original position and rotation
    //     originalPosition = transform.position;
    //     originalRotation = transform.rotation;
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     // Check if the shake timer has expired
    //     if (shakeTimer <= 0) {
    //         // If so, reset the object's position and rotation to their original values
    //         transform.position = originalPosition;
    //         transform.rotation = originalRotation;
    //     } else {
    //         // If not, shake the object
    //         float tilt = Mathf.Sin(Time.time * shakeSpeed) * shakeMagnitude * tiltAngle;
    //         Quaternion targetRotation = Quaternion.Euler(0, 0, tilt);

    //         transform.rotation = originalRotation * targetRotation;

    //         // Decrement the shake timer
    //         shakeTimer -= Time.deltaTime;
    //     }
    // }

    // // Call this method to start the shake effect
    // public void Shake()
    // {
    //     shakeTimer = shakeDuration;
    // }
}
