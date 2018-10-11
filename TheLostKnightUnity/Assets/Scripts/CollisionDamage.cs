using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    // Variables
    public int maxHealth=100;
    public int health;
    public int damageDealt;

    int correctLayer;

    public Color colorToTurn;
    public Color normalColor;
    
    SpriteRenderer spriteRenderer;

    void Start()
    {
        maxHealth = health;
        
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
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void takeDamage(int damageDealt)
    {
        health -= damageDealt;
        Debug.Log("Damage Dealt: " + damageDealt);
    }
    
    IEnumerator Flash()
    {
        int i;

        // Flash
        for(i=0; i<5; i++)
        {
            spriteRenderer.color=colorToTurn;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.color=normalColor;
            yield return new WaitForSeconds(0.05f);

        }
    }
}
