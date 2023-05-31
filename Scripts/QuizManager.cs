using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    // public String word;

    // public static String CurrentWord
    // {
    //     get { return word; }
    //     set { word = value; }
    // }
    
    [SerializeField] AudioSource nextSound;

    

    public void Wrong(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        nextSound.Play();
    }

    public void TryAgain(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        nextSound.Play();
    }

    public void Correct(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        nextSound.Play();
    }

    public void Quiz(){
        SceneManager.LoadScene("Quiz");
        nextSound.Play();
    }



    [SerializeField] private CanvasGroup ui;
    [SerializeField] private CanvasGroup ui2;
    [SerializeField] TextMeshProUGUI AIText;


    int n = 0;

    public void plusOne(){
        n++;
        nextSound.Play();
    }

    int k = 0;

    public void plusOne2(){
        n = 0;
        k++;
        nextSound.Play();
    }

    void Update(){
        if(n == 1){
            ui2.alpha = 1;
            AIText.text = "There'll be 1 picture and 2 options.";
        } else if(n == 2){
            AIText.text = "If you answer all the questions correctly,";
        } else if(n == 3){
            AIText.text = "you'll pass the level.";
        } else if(n == 4){
            AIText.text = "Now, let's start the quiz.";
        } else if(n == 5){
            SceneManager.LoadScene("Quiz");
        // } else if(n == 6){
        //     AIText.text = "Ready to the quiz?";
        // } else if(n == 5){
        //     SceneManager.LoadScene("Quiz2");
        } else if(k == 1){
            AIText.text = "Let's start!";
        } else if(k == 2){
            SceneManager.LoadScene("Quiz3");
        } 
    }


}
