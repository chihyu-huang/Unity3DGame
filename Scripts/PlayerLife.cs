using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerLife : MonoBehaviour
{

    static int life = 3;
    
    [SerializeField] TextMeshProUGUI lifeText;
    [SerializeField] AudioSource deathSound;

    bool dead = false;

    public static int CurrentLife
    {
        get { return life; }
        set { life = value; }
    }

    void Start(){
        if(SceneManager.GetActiveScene().name == "Level1"){
            CurrentLife = 3;
        }
    }

    void Update()
    {
        if(transform.position.y < -1f && !dead || life <= 0){
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<PlayerController>().enabled = false;
            Die();
        }
    }

    void Die(){
        
        Invoke(nameof(ReloadLevel), 0.5f);
        dead = true;
        deathSound.Play();
        Score.CurrentScore = 0;
    }

    void ReloadLevel(){
        SceneManager.LoadScene("End");
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("miss")){
            life--;
            deathSound.Play();
        }
        lifeText.text = "Life: " + life;
    }
}
