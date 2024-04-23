using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnScreenSceneController : MonoBehaviour
{
    public Canvas canvas; // Reference to the Canvas
    public Button backButton; // Reference to the Back button
    public Button forwardButton; // Reference to the Forward button
    public float waitTime = 0.0f; // Time to wait before showing the canvas

    void Start()
    {
        // Add event listeners to the buttons
        backButton.onClick.AddListener(GoToPreviousScene);
        forwardButton.onClick.AddListener(GoToNextScene);

        // Start the ShowCanvas coroutine
        StartCoroutine(ShowCanvas());
    }

    IEnumerator ShowCanvas()
    {
        // Wait for a few seconds
        yield return new WaitForSeconds(waitTime);

        // Show the canvas
        canvas.enabled = true;
    }

    void GoToPreviousScene()
    {
        // Load the previous scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


    void GoToNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}