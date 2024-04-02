using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 10f;
    private float jumpForce = 8f;
    private bool isGrounded;

    //private SpriteRenderer sprite;
    private LayerMask groundLayer; // Layer(s) considered as ground

    private bool canDoubleJump;
    private Rigidbody2D rb;

    public void Start()
    {
        //sprite = gameObject.GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        Jump();

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetAxis("Horizontal") > 0)
        {
            //sprite.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
           // sprite.flipX = true;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Detect when the player stops colliding with the ground
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isGrounded)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(0f, jumpForce));
                canDoubleJump = true;
            }
      
            else
            {
                if (canDoubleJump) {
                rb.velocity = Vector2.up * jumpForce;
                canDoubleJump = false; 
                }
            }
        }
    }

}

