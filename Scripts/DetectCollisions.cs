using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DetectCollisions: MonoBehaviour
{
    // public boolean hit = false;

    [SerializeField] private CanvasGroup ui;
    [SerializeField] private float timeToWait = 0.3f;
    // [SerializeField] private gameObject miss;
    public GameObject objectToDisable;


    //private void 
    IEnumerator OnTriggerEnter(Collider other){
        ui.alpha = 1;
        
        
        // gameObject.SetActive(false);
        // Debug.Log("Trigger entered by " + gameObject.name);
        yield return new WaitForSeconds(timeToWait);
        Destroy(gameObject);
        objectToDisable.SetActive(false);

    

        ui.alpha = 0;
        
        
    }


}
