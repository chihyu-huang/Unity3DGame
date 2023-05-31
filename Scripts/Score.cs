using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    static int score = 0;

    public static int CurrentScore
    {
        get { return score; }
        set { score = value; }
    }

    void Start(){
        if(SceneManager.GetActiveScene().name == "Level1"){
            CurrentScore = 0;
        }
    }
    
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] AudioSource correctSound;
    [SerializeField] AudioSource falseSound;

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("correct") || other.gameObject.CompareTag("correct2")){
            score++;
            correctSound.Play();
        } else if (other.gameObject.CompareTag("false") || other.gameObject.CompareTag("false2")){
            // Destroy(other.gameObject);
            score--;
            falseSound.Play();
        } 
        scoreText.text = "Score: " + score;
    }
}
