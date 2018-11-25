using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    // Variables

    Rigidbody2D playerRB;
    Collider2D PlayerCollider;
    TouchMovement touchMovement;

    public bool isWalking;
    public bool moveRight;
    public bool moveLeft;
    public bool jump;

    public float moveSpeed = 3.5f;
    public float jumpForce;
    public float lowJumpMultiplier = 2.5f;
    public float fallMultiplier = 2f;
    public bool isGrounded;


    public float dashForce;
    public float dashMultiplier;
    public int direction = 0;

    public float playerMaxStamina = 300;
    public float playerStamina;
    float staminaPercentage;
    Image staminaBarImage;
    public float staminaRegenRate;

    Animator animator;

    GameObject playerPrefab;

    // variable to hold a reference to our SpriteRenderer component
    private SpriteRenderer mySpriteRenderer;
    private ParticleSystem myParticleSystem;

    // This function is called just one time by Unity the moment the game loads
    private void Awake()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myParticleSystem = GetComponent<ParticleSystem>();
        playerPrefab = GameObject.FindGameObjectWithTag("Player");
        animator = playerPrefab.GetComponent<Animator>();
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
            animator.SetBool("isJumping", true);
            isGrounded = false;
        }
    }

    void Update()
    {
        if (isGrounded == true)
        {
            animator.SetBool("isJumping", false);
        }
        else
        {
            animator.SetBool("isJumping", true);
        }
    }

    void Start()
    {
        playerStamina = playerMaxStamina;
        // Assign our Player's rigidybody to 'rigidbody'
        playerRB = GetComponent<Rigidbody2D>();
        PlayerCollider = GetComponent<Collider2D>();
        touchMovement = FindObjectOfType<TouchMovement>();

        GameObject staminaBarObject = GameObject.FindGameObjectWithTag("StaminaBar");

        staminaBarImage = staminaBarObject.GetComponent<Image>();

    }

    void FixedUpdate()
    {
        // Stamina bar stufff
        staminaPercentage = playerStamina / playerMaxStamina;
        staminaBarImage.fillAmount = staminaPercentage;

        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        if (playerStamina < playerMaxStamina)
        {
            playerStamina += staminaRegenRate * Time.deltaTime;
        }

        // if the variable isn't empty (we have a reference to our SpriteRenderer)
        if (mySpriteRenderer != null)
        {

            if (direction == 0 || direction == 1 || direction == 2)
            {

                // Moving left
                if (moveLeft == true || Input.GetKeyDown(KeyCode.A))
                {
                    isWalking = true;
                    direction = 1;
                    playerRB.velocity = new Vector2(-moveSpeed, playerRB.velocity.y);
                    // flip the sprite
                    mySpriteRenderer.flipX = true;
                }

                // Moving right
                if (moveRight == true || Input.GetKeyDown(KeyCode.D))
                {
                    isWalking = true;
                    direction = 2;
                    playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);
                    // flip the sprite
                    mySpriteRenderer.flipX = false;
                }

                // Jumping
                if ((jump == true || Input.GetKeyDown(KeyCode.Space)) && isGrounded == true)
                {
                    playerStamina -= 10;
                    playerRB.AddForce((Vector2.up) * jumpForce * ((fallMultiplier - 1) * Time.deltaTime));
                    isGrounded = false;
                }

                // Dashing
                // Android touch movement
                if (playerStamina <= 0)
                {
                    direction = 0;
                }
                else
                {
                    if (direction == 1 && touchMovement.leftTouchCount >= 2 && playerStamina > 25)
                    {
                        myParticleSystem.Play();
                        animator.SetBool("isDashing", true);
                        playerRB.velocity = Vector2.left * dashForce * dashMultiplier * Time.deltaTime;
                        playerStamina -= 10;
                        //playerRB.AddForce((Vector2.right) * dashSpeed  * Time.deltaTime);
                    }
                    else
                    {
                        animator.SetBool("isDashing", false);

                    }

                    // Android touch movement
                    if (direction == 2 && touchMovement.rightTouchCount >= 2 && playerStamina > 25)
                    {
                        myParticleSystem.Play();
                        animator.SetBool("isDashing", true);
                        //playerRB.AddForce((Vector2.left) * dashSpeed * Time.deltaTime);
                        playerStamina -= 10;
                        playerRB.velocity = Vector2.right * dashForce * dashMultiplier * Time.deltaTime;
                    }
                    else
                    {
                        animator.SetBool("isDashing", false);

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


