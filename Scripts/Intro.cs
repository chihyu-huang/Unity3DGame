using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Intro : MonoBehaviour
{
    private float speed = 0.0f;
    // [SerializeField] private CanvasGroup ui;
    // [SerializeField] TextMeshProUGUI AIText;
    [SerializeField] private float timeToWait = 0.0f;

    void Start(){
        // if(SceneManager.GetActiveScene().name == "Practice"){
        //     // timeToWait = 100.0f;
        // }
    }


    // [SerializeField] AudioSource correctSound;
    // [SerializeField] AudioSource falseSound;

    IEnumerator OnTriggerEnter(Collider other){
        // ui.alpha = 1;
        if(other.gameObject.CompareTag("speed")){
            speed = 5.0f;
        } else if(other.gameObject.CompareTag("stop")){
            speed = 0f;
        }

        yield return new WaitForSeconds(timeToWait);

        // ui.alpha = 0;
    }

    void Update(){
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

}
