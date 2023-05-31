using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip defaultMusic;  // Set this in the Inspector
    public AudioClip scene1Music;  // Set this in the Inspector
    public AudioClip scene2Music;  // Set this in the Inspector
    string sceneName;

    private AudioSource audioSource;

    // void Start(){
    //     sceneName = SceneManager.GetActiveScene().name;
    //     Awake();
    // }
    void Update(){
        sceneName = SceneManager.GetActiveScene().name;
    }


    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("bgm");

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);


        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        // Debug.Log(audioSource);

        // Check which scene is currently loaded and play the appropriate music
        // int index = SceneManager.GetActiveScene.index();

        if (sceneName == "Level1" || sceneName == "Level2")
        {
            // Stop the default music and play new music for Scene1
            audioSource.Stop();
            audioSource.clip = scene1Music;
            audioSource.Play();
            // Destroy(gameObject);

        }
        else if (sceneName == "Start" || sceneName == "Intro" || sceneName == "Practice" || sceneName == "End")
        {
            // Stop the default music and play new music for Scene2
            audioSource.Stop();
            audioSource.clip = scene2Music;
            audioSource.Play();
            // DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Play the default music for all other scenes
            audioSource.clip = defaultMusic;
            audioSource.Play();
            // DontDestroyOnLoad(gameObject);
        }
        // Debug.Log(sceneName);

    }
}