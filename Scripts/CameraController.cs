using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // private float speed = 15.0f;
    // private float turnSpeed = 40.0f;
    // private float horizontalInput;
    // private float verticalInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update(){

        // horizontalInput = Input.GetAxis("Horizontal");
        // verticalInput = Input.GetAxis("Vertical");
        // transform.Translate(Vector3.forward * Time.deltaTime * speed); // * verticalInput);
        // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset ;
    }
}
