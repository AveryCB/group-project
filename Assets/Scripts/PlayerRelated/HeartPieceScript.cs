using UnityEngine;

public class HeartPieceScript : MonoBehaviour
{
    public GameObject door;
    public Sprite heartPieceSprite;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CollectHeartPiece();
        }
    }

    private void CollectHeartPiece()
    {
        // Display picture or animation
        // You can use UI elements or instantiate a prefab
        // For simplicity, let's just deactivate the heart piece object
        gameObject.SetActive(false);

        // Attach heart piece sprite to the door
        door.GetComponent<DoorScript>().AttachHeartPiece(heartPieceSprite);
    }
}