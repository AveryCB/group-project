using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundAudio : MonoBehaviour
{
    public AudioClip audioClip; // The audio clip to play
    private AudioSource audioSource; // The audio source to play the audio clip

    void Start()
    {
        // Get the audio source component
        audioSource = GetComponent<AudioSource>();

        // If there's no audio source component, add one
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Set the audio clip
        audioSource.clip = audioClip;

        // Play the audio clip in a loop
        audioSource.loop = true;
        audioSource.Play();

        // Prevent this game object from being destroyed when a new scene is loaded
        DontDestroyOnLoad(gameObject);

        // Add a listener to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Game - Panel 1")
        {
            audioSource.enabled = false;
        }
        // If the "Panel 2" scene is loaded, enable the audio source
        else if (scene.name == "Panel 2")
        {
            audioSource.enabled = true;
        }
        // If the "Panel 2" scene is loaded, enable the audio source
        else if (scene.name == "Panel 6")
        {
            audioSource.enabled = true;
        }
        // If the "Panel 7" scene is loaded, disable the audio source
        else if (scene.name == "Panel 7")
        {
            audioSource.enabled = false;
        }
        // If the "Panel 8" scene is loaded, enable the audio source
        else if (scene.name == "Panel 8")
        {
            audioSource.enabled = true;
        }
        // If the "Panel 16" scene is loaded, disable the audio source
        else if (scene.name == "Panel 16")
        {
            audioSource.enabled = false;
        }
    }
}