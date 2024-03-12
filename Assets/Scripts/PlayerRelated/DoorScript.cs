using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public SpriteRenderer doorRenderer;
    public Sprite[] heartPieceSprites; // Array to hold sprites for each piece of the heart
    public Sprite openDoorSprite;
    public Collider2D playerCollider; // Reference to the player's collider
    public Collider2D doorCollider; // Reference to the door's collider

    private int collectedPieces = 0;
    private bool canOpenDoor = false;
    private bool doorOpened = false;

    private void Update()
    {
        if (canOpenDoor && Input.GetKeyDown(KeyCode.E) && playerCollider.IsTouching(doorCollider))
        {
            OpenDoor();
        }
    }

    public void AttachHeartPiece(Sprite heartPieceSprite)
    {
        if (!doorOpened && collectedPieces < 4)
        {
            // Update the door sprite with the collected heart piece
            doorRenderer.sprite = heartPieceSprites[collectedPieces];
            collectedPieces++;

            if (collectedPieces == 4)
            {
                canOpenDoor = true;
            }
        }
    }

    private void OpenDoor()
    {
        // Play door opening animation or sound
        // For simplicity, let's just change the door sprite
        doorRenderer.sprite = openDoorSprite;
        doorOpened = true;
        Invoke("LoadNextScene", 2f);
    }

    private void LoadNextScene()
    {
        // Load the next scene after 2 seconds
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}