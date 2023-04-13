using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    int score = 0;
    
    [SerializeField] TextMeshProUGUI scoreText;

    // [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("correct")){
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score: " + score;
            // collectionSound.Play();
        } else if (other.gameObject.CompareTag("false")){
            Destroy(other.gameObject);
            score--;
            scoreText.text = "Score: " + score;
            // collectionSound.Play();
        }
    }
}
