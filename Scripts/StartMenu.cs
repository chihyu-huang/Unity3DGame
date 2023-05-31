using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    // AIController ai = new AIController();
    // private float speed = 1.0f;
    [SerializeField] AudioSource nextSound;
    
    public void StartGame(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Level1");
    }
    public void PracticeGame(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Intro");
    }



    int n = 0;

    [SerializeField] private CanvasGroup ui;
    [SerializeField] TextMeshProUGUI AIText;


    public void Next(){
        n++;
        nextSound.Play();
    }

    void Update(){
        if(n == 1){
            AIText.text = "I'm here to assist you learn English.";
        } else if(n == 2){
            AIText.text = "You'll be able to control the car when the game starts.";
        } else if(n == 3){
            AIText.text = "Your score is at the upper left corner.";
        } else if(n == 4){
            AIText.text = "The life you left is at the upper right.";
        } else if(n == 5){
            AIText.text = "As level goes up, the car will speed up.";
        } else if(n == 6){
            AIText.text = "You use left or right to hit the right answer.";
        } else if(n == 7){
            // speed = 5.0f;
            AIText.text = "Let's hit the road.";
        } else if(n == 8){
            SceneManager.LoadScene("Practice");
        // } else if(n == ){
        //     AIText.text = "";
        // } else if(n == ){
        //     AIText.text = "";
        // } else if(n == ){
        //     AIText.text = "";
        // } else if(n == ){
        //     AIText.text = "";
        // } else if(n == ){
        //     AIText.text = "";

        }
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
    }


}
