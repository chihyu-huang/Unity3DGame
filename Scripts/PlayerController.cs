using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float xRange = 5;
    private float speed = 15.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;

    public GameObject projectilePrefab;



    void Update()
    {
        // if(transform.position.x < -xRange){
        //     transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        // }
        // if(transform.position.x > xRange){
        //     transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        // }
        // transform.Translate(0, 0, 0.1f);
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed); // * verticalInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("shoot");
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    
}
