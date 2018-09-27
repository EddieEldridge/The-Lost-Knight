using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Variables
    public float maxSpeed = 3.5f;
    //float shipBoundaryRadius = 5f;

    void Start ()
    {
		
	}

    void Update()
    {

        // Assign players postion to a Vector3 named pos
        Vector3 pos = transform.position;

        // Movement for the ship (Vertical)
        pos.y += Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime;
        transform.position = pos;

        // Movement for the ship (Horizontal)
        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;
        transform.position = pos;

        // Restricts the player to camera view
        pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);
    }
}
