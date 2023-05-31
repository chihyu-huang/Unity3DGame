using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class AIController : MonoBehaviour
{
    public float speed = 14.5f;
    private float verticalInput;

    // public Transform objectTransform; 


    void Update()
    {
        // verticalInput = Input.GetAxis("Vertical");


        if(SceneManager.GetActiveScene().name == "Intro"){
            // speed = 1f;
            // transform.Rotate(Vector3.up, Time.deltaTime * speed * 50f);

        } else if(SceneManager.GetActiveScene().name == "Practice"){
            speed = 7.0f;
            // transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        } else if(SceneManager.GetActiveScene().name == "Level2"){
            speed = 19.5f;
        }
        transform.Translate(Vector3.right * Time.deltaTime * speed);
        
        // Vector3 position = objectTransform.position;
        // position.z = PlayerController.zPosition;
        
    }
}
