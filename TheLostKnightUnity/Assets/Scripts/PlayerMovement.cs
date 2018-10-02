using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Variables
    public float moveSpeed = 3.5f;
    public bool moveRight;
    public bool moveLeft;
    public Rigidbody2D rigidbody;
    //float shipBoundaryRadius = 5f;

    void Start ()
    {
		rigidbody=GetComponent<Rigidbody2D>();
	}

    void Update()
    {

        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        // Movement for the ship (Vertical)
        //pos.y += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
       // transform.position = pos;

        // Movement for the ship (Horizontal)
       // pos.x += Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
       // transform.position = pos;


        // Android touch movement
        if (moveRight)
        {
            rigidbody.velocity = new Vector2(moveSpeed, rigidbody.velocity.y);
        }
        if (moveLeft)
        {
            rigidbody.velocity = new Vector2(-moveSpeed, rigidbody.velocity.y);
        }

        // Restricts the player to camera view
        pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
