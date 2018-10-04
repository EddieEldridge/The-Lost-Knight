using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    // Variables
    public GameObject arrowPrefab;
    public float fireDelay = 0.1f;
    float cooldownTimer = 0;
    int arrowLayer;
    float offset =5 ;
    public bool isFiring;

    void Start ()
    {
        arrowLayer = gameObject.layer;
    }
    // Update is called once per frame
	void Update ()
    {
        cooldownTimer -= Time.deltaTime;

        // Shooting script
		if(isFiring ==true && cooldownTimer <=0)
        {
            Debug.Log("Player Shooting!");

            // Set delay in between shots
            cooldownTimer = fireDelay;

            // Create instance of bulletPrefab every time player 'fires'
            GameObject arrowGO = (GameObject)Instantiate(arrowPrefab, transform.position +(offset *transform.forward), Quaternion.identity);
            arrowGO.layer = arrowLayer;
        }
	}
}
