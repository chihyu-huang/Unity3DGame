using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class AI : MonoBehaviour
{
    [SerializeField] private CanvasGroup ui;
    [SerializeField] TextMeshProUGUI AIText;
    [SerializeField] private float timeToWait = 1.5f;

    void Start(){
        if(SceneManager.GetActiveScene().name == "Practice"){
            // timeToWait = 100.0f;
        }
    }

    int i = 0;

    // [SerializeField] AudioSource correctSound;
    // [SerializeField] AudioSource falseSound;

    IEnumerator OnTriggerEnter(Collider other){
        ui.alpha = 1;

            if(other.gameObject.CompareTag("intro")){
                if(i == 0){
                    AIText.text = "Let's get started!";
                } else if(i == 1){
                    AIText.text = "In normal game, the speed will be faster.";
                } else if(i == 2){
                    AIText.text = "Here, just learn how does this game work.";
                } else if(i == 3){
                    AIText.text = "First, let's see if you miss hitting an answer.";
                } else if(i == 4){
                    AIText.text = "You'll lose a life.";
                } else if(i == 5){
                    AIText.text = "Now, let's press 'right' to make the car turn a bit.";
                } else if(i == 6){
                    AIText.text = "You'll get one point if you hit the correct answer.";
                } else if(i == 7){
                    AIText.text = "Now, press 'left' to make the car stay in left lane.";
                } else if(i == 8){
                    AIText.text = "You'll lose one point if you hit the wrong answer.";
                } else if(i == 9){
                    AIText.text = "Be careful not to fall outside of the lane.";
                } else if(i == 10){
                    AIText.text = "You'll die and start over.";
                } else if(i == 11){
                    AIText.text = "Now, let's start the game.";
                } else if(i == 12){
                    AIText.text = "Hit the dark wall to level up and learn!";
                }
                i++;
            // } else if (other.gameObject.CompareTag("miss")){
            //     AIText.text = "You'll lose 1 life.";
            }
            if (other.gameObject.CompareTag("road")){
                AIText.text = "Let's hit the road!";
            } else if (other.gameObject.CompareTag("up")){
                AIText.text = "Hit the wall and level up!";
            } else if (other.gameObject.CompareTag("correct")){
                AIText.text = "You're doing great!";
            } else if (other.gameObject.CompareTag("correct2")){
                AIText.text = "I'm so proud of you!";
            } else if (other.gameObject.CompareTag("false")){
                AIText.text = "Keep it up!!";
            } else if (other.gameObject.CompareTag("false2")){
                AIText.text = "Let's get the next right.";
            } else if (other.gameObject.CompareTag("miss")){
                AIText.text = "Try to catch the next one!";
            } else if (other.gameObject.CompareTag("apple")){
                AIText.text = "This is 'apple'!";
            } else if (other.gameObject.CompareTag("banana")){
                AIText.text = "This is 'banana'!";
            } else if (other.gameObject.CompareTag("pear")){
                AIText.text = "This is 'pear'!";
            } else if (other.gameObject.CompareTag("sandwich")){
                AIText.text = "This is 'sandwich'!";
            } else if (other.gameObject.CompareTag("fox")){
                AIText.text = "This is 'fox'!";
            } else if (other.gameObject.CompareTag("poodle")){
                AIText.text = "This is 'poodle'!";
            } else if (other.gameObject.CompareTag("skunk")){
                AIText.text = "This is 'skunk'!";
            } else if (other.gameObject.CompareTag("poodle")){
                AIText.text = "This is 'poodle'!";
            }  
        

    

        yield return new WaitForSeconds(timeToWait);

        ui.alpha = 0;
    }

}
