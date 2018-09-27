using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    // Variables
    public GameObject bulletPrefab;
    public float fireDelay = 0.1f;
    float cooldownTimer = 0;
    int bulletLayer;

    void Start ()
    {
        bulletLayer = gameObject.layer;
    }
    // Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        // Shooting script
		if(Input.GetButton("Fire1") && cooldownTimer <=0)
        {
           // Debug.Log("Player Shooting!");

            // Set delay in between shots
            cooldownTimer = fireDelay;

            // Create instance of bulletPrefab every time player 'fires'
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
	}
}
