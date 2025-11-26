using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;

    public AudioClip jump;
    public AudioSource playerSFX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Constant Forward movement
        rb.linearVelocity = new Vector2(moveSpeed, rb.linearVelocity.y);

        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        // jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            playerSFX.PlayOneShot(jump);
            Jump();
        }
    }

    private void Jump()
    {

        rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
}