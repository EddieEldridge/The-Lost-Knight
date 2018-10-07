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
    bool isGrounded;


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

        // Android touch movement
        if (moveRight==true)
        {
            playerRB.velocity = new Vector2(moveSpeed, playerRB.velocity.y);
        }
        if (moveLeft==true)
        {
            playerRB.velocity = new Vector2(-moveSpeed, playerRB.velocity.y);
        }

        if (jump==true && isGrounded==true)
        {
            playerRB.AddForce((Vector2.up) * jumpForce); 
        }

        // Restricts the player to camera view
     /*    pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos); */
    }
}
