using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    private float xRange = 5;
    private float speed = 15.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float verticalInput;
    // private static float zzz = 0;

    // public static float zPosition
    // {
    //     get { return zzz; }
    // }

    // public GameObject projectilePrefab;
    // public Transform carTransform;
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(SceneManager.GetActiveScene().name == "Intro"){
            speed = 0f;
        }
        if(SceneManager.GetActiveScene().name == "Practice"){
            speed = 7.0f;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        }
        if(SceneManager.GetActiveScene().name == "Level2"){
            speed = 20.0f;
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // transform.Translate(Vector3.forward * Time.deltaTime * speed); // * verticalInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // Debug.Log(carTransform.position.z);
        // zzz= carTransform.position.z;
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     Debug.Log("shoot");
        //     Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        // }

        // Debug.Log(SceneManager.GetActiveScene().name);

    }

    
}
