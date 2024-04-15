using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement; // Import the SceneManagement namespace

public class Scene17VideoPlayer : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play(); // Play the video
        videoPlayer.loopPointReached += LoadNextScene; // Add event listener
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Method to load the next scene
    void LoadNextScene(VideoPlayer vp)
    {
        SceneManager.LoadScene("Panel 18"); // Load the next scene
    }
}