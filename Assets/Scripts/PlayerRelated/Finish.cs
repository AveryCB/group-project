using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Import this namespace for the Image class

public class Finish : MonoBehaviour
{
    public AudioSource sound; // The sound to play
    public Image blackOverlay; // The black overlay
    public GameObject player; // The player

    // Call this method when the button is clicked
    public void SwitchToPanel2()
    {
        blackOverlay.enabled = true;

        // Disable the player's movement and look scripts
        player.GetComponent<FPSInput>().enabled = false;
        player.GetComponent<MouseLook>().enabled = false;

        // Lock the cursor and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        // Play the sound
        sound.Play();

        // Start the coroutine
        StartCoroutine(FadeToBlack());
    }

    IEnumerator FadeToBlack()
    {
        // Gradually increase the opacity of the black overlay over 6 seconds
        for (float i = 0; i <= 1; i += Time.deltaTime / 6)
        {
            // Change the color of the black overlay
            blackOverlay.color = new Color(0, 0, 0, i);
            yield return null;
        }

        // Load the scene named "Panel 2"
        SceneManager.LoadScene("Panel 2");
    }
}