using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour {

    // Variables
    public Vector3 bulletOffset = new Vector3(0,0.5f,0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.5f;
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
		if(cooldownTimer <=0)
        {
            //Debug.Log("Enemy Shooting!");

            // Set delay in between shots
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletOffset;

            // Create instance of bulletPrefab every time player 'fires'
            GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;;
        }
	}
}
