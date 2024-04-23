using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Import this namespace

public class Choice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Call this method when the first button is clicked
    public void Button1Clicked()
    {
        SceneManager.LoadScene("Panel 5"); // Replace "NextScene" with the name of your next scene
    }

    // Call this method when the second button is clicked
    public void Button2Clicked()
    {
        SceneManager.LoadScene("Panel 5"); // Replace "NextScene" with the name of your next scene
    }
}