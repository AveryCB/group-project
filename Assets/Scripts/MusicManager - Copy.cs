using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public AudioClip musicClip; // The music to play
    private AudioSource audioSource; // The audio source to play the music

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
        audioSource.clip = musicClip;

        // Don't destroy this game object when a new scene is loaded
        DontDestroyOnLoad(gameObject);

        // Add a listener to the sceneLoaded event
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // If the "Panel 2" scene is loaded, disable the audio source
        if (scene.name == "Panel 2")
        {
            audioSource.enabled = false;
        }
        // If the "Panel 7" scene is loaded, enable the audio source and play the music
        else if (scene.name == "Panel 7")
        {
            audioSource.enabled = true;
            audioSource.Play();
        }
        // If the "Panel 8" scene is loaded, disable the audio source
        else if (scene.name == "Panel 8")
        {
            audioSource.enabled = false;
        }
        // If the "Panel 17" scene is loaded, enable the audio source and play the music
        else if (scene.name == "Panel 17")
        {
            audioSource.enabled = true;
            audioSource.Play();
        }
        // If the "Video" scene is loaded, disable the audio source
        else if (scene.name == "Video")
        {
            audioSource.enabled = false;
        }
    }
}