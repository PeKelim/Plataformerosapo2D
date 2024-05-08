using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;

    float raycastDistance = 0.2f;
    private Transform playerPosition;

    public bool grounded;

    Rigidbody2D rb2D;
    private void Start()
    {
        playerPosition = GetComponent<Transform>();
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        IsGrounded();

        {
            float horizontalMovement = Input.GetAxis("Horizontal");
            rb2D.velocity = new Vector2(horizontalMovement * speed, rb2D.velocity.y);
        } // Horizontal Movement

        {
            if (Input.GetButtonDown("Jump") && grounded)
            {
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
            }
        } // Jump
    }
    void IsGrounded()
    {
        int layerMask = 1 << 7;

        RaycastHit2D hit = Physics2D.Raycast(playerPosition.position, Vector2.down, raycastDistance, layerMask);
        grounded = hit.collider != null;
    } // Verify if the player is grounded
}