using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions_False : MonoBehaviour
{
    [SerializeField] private CanvasGroup ui;
    [SerializeField] private float timeToWait = 0.2f;

    //private void 
    IEnumerator OnTriggerEnter(Collider other){
        ui.alpha = 1;
        Destroy(gameObject);
        // other.gameObject.SetActive(false);
        Debug.Log("Trigger entered by " + gameObject.name);

        yield return new WaitForSeconds(timeToWait);
        ui.alpha = 0;
    }
}
