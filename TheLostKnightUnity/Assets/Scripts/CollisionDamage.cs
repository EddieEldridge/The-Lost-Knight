using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    // Variables
    public float invulnPeriod = 0;
    public int health = 100;
    float invulnTimer = 0;
    int correctLayer;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        correctLayer = gameObject.layer;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if(spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            if(spriteRenderer == null)
            {
                 Debug.Log("Error: No sprite found.");
            }
        }
        
    }
    void OnTriggerEnter2D()
    {
        health--;

        if(invulnPeriod > 0)
        {
            invulnTimer = invulnPeriod;
            gameObject.layer = 10;
        }

    }

    void Update()
    {

        if(invulnTimer > 0)
        {
            invulnTimer -= Time.deltaTime;


            if(invulnTimer <= 0)
            {
                 gameObject.layer = correctLayer;

                 // Displaying invincibility
                 if(spriteRenderer != null)
                 {
                     spriteRenderer.enabled=true;
                 }
            }

            else
            {
                  if(spriteRenderer != null)
                 {
                     spriteRenderer.enabled=!spriteRenderer.enabled;
                 }
            }
        }

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
