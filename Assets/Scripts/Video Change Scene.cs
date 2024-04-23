using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // Import this namespace
using UnityEngine.SceneManagement; // Import this namespace

public class VideoChangeScene : MonoBehaviour
{
    private VideoPlayer videoPlayer; // Add this line

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>(); // Get the VideoPlayer component
        videoPlayer.playOnAwake = true; // Play the video as soon as the scene starts

        // Add a handler for the loopPointReached event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // This method will be called when the video ends
    void OnVideoEnd(VideoPlayer vp)
    {
        SceneManager.LoadScene("Game - Panel 1"); // Replace "NextScene" with the name of your next scene
    }
}