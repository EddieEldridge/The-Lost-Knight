using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Variables
    Rigidbody2D playerRB;
    Collider2D PlayerCollider;
    public float moveSpeed = 3.5f;
    public bool moveRight;
    public bool moveLeft;
    public bool jump;
    public float jumpForce;
    public float lowJumpMultiplier = 2.5f;
    public float fallMultiplier = 2f;
    bool isGrounded;

    // variable to hold a reference to our SpriteRenderer component
    private SpriteRenderer mySpriteRenderer;

    // This function is called just one time by Unity the moment the game loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Jumping and checking if the player is grounded or not
    // "Changed 'Platform' to the name of the GameObject you wanna check if ur standing on it or not
    void OnCollisionEnter2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name == "Platform")
        {
            isGrounded = true;
        }
    }
     
     void OnCollisionExit2D(Collision2D theCollision)
    {
        if (theCollision.gameObject.name == "Platform")
        {
            isGrounded = false;
        }
    }
    void Start ()
    {   
        // Assign our Player's rigidybody to 'rigidbody'
		playerRB=GetComponent<Rigidbody2D>();
        PlayerCollider=GetComponent<Collider2D>();
	}

    void Update()
    {

        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        // if the variable isn't empty (we have a reference to our SpriteRenderer)
        if (mySpriteRenderer != null)
        {
            
            // Android touch movement
            if (moveRight==true)
            {
                playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);
                
                // flip the sprite
                mySpriteRenderer.flipX = false;
            }
            if (moveLeft==true)
            {
                playerRB.velocity = new Vector2(-moveSpeed, playerRB.velocity.y);
                // flip the sprite
                mySpriteRenderer.flipX = true;

            }

            if (jump==true && isGrounded==true)
            {
                playerRB.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier -1) * Time.deltaTime;
            }
        }

        // Restricts the player to camera view
     /*    pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos); */
    }
}