using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContinueOrExit : MonoBehaviour
{
    public Button ContinueButton; // Reference to the Continue button
    public Button ExitButton; // Reference to the Exit button
    public float waitTime = 5.0f; // Time to wait before showing the buttons

    void Start()
    {
        // Add event listeners to the buttons
        ContinueButton.onClick.AddListener(GoToVideoScene);
        ExitButton.onClick.AddListener(ExitApplication);

        // Disable the buttons
        ContinueButton.gameObject.SetActive(false);
        ExitButton.gameObject.SetActive(false);

        // Start the ShowButtons coroutine
        StartCoroutine(ShowButtons());
    }

    IEnumerator ShowButtons()
    {
        // Wait for a few seconds
        yield return new WaitForSeconds(waitTime);

        // Show the buttons
        ContinueButton.gameObject.SetActive(true);
        ExitButton.gameObject.SetActive(true);
    }

    void GoToVideoScene()
    {
        // Load the "Video" scene
        SceneManager.LoadScene("Video");
    }

    void ExitApplication()
    {
        // Close the application
        Application.Quit();
    }
}