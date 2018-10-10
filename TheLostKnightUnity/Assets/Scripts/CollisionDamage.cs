using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    // Variables
    public float invulnPeriod = 0;
    public int health;
    float invulnTimer = 0;
    int correctLayer;
    public Color colorToTurn;
    public Color normalColor;
    
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
        StartCoroutine(Flash());

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

    public void takeDamage(int damage)
    {
        Debug.Log("Damage taken by enemy!");
        health -= damage;
    }
    
    IEnumerator Flash()
    {
        int i;

        // Flash
        for(i=0; i<5; i++)
        {
            spriteRenderer.color=colorToTurn;
            yield return new WaitForSeconds(0.1f);
            spriteRenderer.color=normalColor;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
