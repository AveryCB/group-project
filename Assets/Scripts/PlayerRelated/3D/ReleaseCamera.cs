using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseCamera : MonoBehaviour
{
    public MouseLook mouseLookScript;
    public GameObject playerCamera;
    public GameObject movementCamera;
    public GameObject releaseButton;
    public GameObject continueButton;  
    public void OnReleaseButtonClick()
	{
        mouseLookScript.enabled = false;
        playerCamera.SetActive(false);
        movementCamera.SetActive(true);
        releaseButton.SetActive(false);
        continueButton.SetActive(true);

	}
}
