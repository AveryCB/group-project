using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// basic WASD-style movement control
// commented out line demonstrates that transform.Translate instead of charController.Move doesn't have collision detection

[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FPSInput : MonoBehaviour {
	public float speed = 6.0f;
	public float gravity = -9.8f;

	private CharacterController charController;
	
	void Start() {
		charController = GetComponent<CharacterController>();
	}
	
	void Update() {
		
    float deltaX = Input.GetAxis("Horizontal") * speed;
    float deltaZ = Input.GetAxis("Vertical") * speed;
    Vector3 movement = new Vector3(deltaX, 0, deltaZ);
    movement = Vector3.ClampMagnitude(movement, speed);

    // Check if the space bar or left shift key is pressed
    if (Input.GetKey(KeyCode.Space))
    {
        movement.y = speed; // Move up
    }
    else if (Input.GetKey(KeyCode.LeftShift))
    {
        movement.y = -speed; // Move down
    }
    else
    {
        movement.y = gravity;
    }

    movement *= Time.deltaTime;
    movement = transform.TransformDirection(movement);
    charController.Move(movement);
	}
}
