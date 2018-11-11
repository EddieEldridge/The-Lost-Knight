using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Variables
    Rigidbody2D playerRB;
    Collider2D PlayerCollider;
    TouchMovement touchMovement;

    public bool moveRight;
    public bool moveLeft;
    public bool jump;

    public float moveSpeed = 3.5f;
    public float jumpForce;
    public float lowJumpMultiplier = 2.5f;
    public float fallMultiplier = 2f;
    public bool isGrounded;


    public float dashSpeed;
    public float dashTime;
    public float startDashTime;
    public int direction = 0;

    // variable to hold a reference to our SpriteRenderer component
    private SpriteRenderer mySpriteRenderer;
    private ParticleSystem myParticleSystem;

    // This function is called just one time by Unity the moment the game loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myParticleSystem = GetComponent<ParticleSystem>();
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

    void Start()
    {
        // Assign our Player's rigidybody to 'rigidbody'
        playerRB = GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();
        touchMovement = FindObjectOfType<TouchMovement>();

        dashTime = startDashTime;
    }

    void Update()
    {

        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        // if the variable isn't empty (we have a reference to our SpriteRenderer)
        if (mySpriteRenderer != null)
        {

            if (direction == 0 || direction == 1 || direction == 2)
            {

                // Moving left
                if (moveLeft == true || Input.GetKeyDown(KeyCode.A))
                {
                    direction = 1;
                    playerRB.velocity = new Vector2(-moveSpeed, playerRB.velocity.y);
                    // flip the sprite
                    mySpriteRenderer.flipX = true;
                }

                // Moving right
                if (moveRight == true || Input.GetKeyDown(KeyCode.D))
                {
                    direction = 2;
                    playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);
                    // flip the sprite
                    mySpriteRenderer.flipX = false;
                }

                // Jumping
                if ((jump == true  || Input.GetKeyDown(KeyCode.Space)) && isGrounded == true )
                {
                    playerRB.AddForce((Vector2.up) * jumpForce * ((fallMultiplier - 1) * Time.deltaTime));
                }


                // Dashing
                // Android touch movement
                if (dashTime <= 0)
                {
                    direction = 0;
                    dashTime = startDashTime;
                    playerRB.velocity = Vector2.zero;
                }
                else
                {
                    dashTime -= Time.deltaTime;

                    if (direction == 1 && touchMovement.leftTouchCount >= 2)
                    {
                        myParticleSystem.Play();
                        playerRB.velocity = Vector2.left * dashSpeed;
                    }

                    // Android touch movement
                    if (direction == 2 && touchMovement.rightTouchCount >= 2)
                    {
                        myParticleSystem.Play();
                        playerRB.velocity = Vector2.right * dashSpeed;
                    }

                }






            }





        }



    }

    // Restricts the player to camera view
    /*    pos = Camera.main.WorldToViewportPoint(transform.position);
       pos.x = Mathf.Clamp01(pos.x);
       pos.y = Mathf.Clamp01(pos.y);
       transform.position = Camera.main.ViewportToWorldPoint(pos); */
}


