using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene18Fadeouttowhite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    public float fadeOutTime = 2.0f; // Time it takes to fade out

    // Start is called before the first frame update
    void Start()
    {
        // Start the FadeOut coroutine
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut()
    {
        // Fade out over time
        for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeOutTime)
        {
            // Lerp the color's alpha to 1
            Color newColor = new Color(1, 1, 1, Mathf.Lerp(0, 1, t));
            spriteRenderer.color = newColor;
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}