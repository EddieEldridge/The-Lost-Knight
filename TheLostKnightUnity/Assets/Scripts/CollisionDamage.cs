using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    
    // Variables
    int correctLayer;
    public int damageDealt;

    public Color colorToTurn;
    public Color normalColor;
    
    SpriteRenderer spriteRenderer;
    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;


    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        enemyHealth = FindObjectOfType<EnemyHealth>();

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
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            playerHealth.health -= damageDealt;
            Debug.Log("Damage Dealt: " + damageDealt);
            StartCoroutine(Flash());   
        }       
    }

    void Update()
    {
      
    }

    public void takeDamage(int damageDealt)
    {
       enemyHealth.health-=damageDealt;
       StartCoroutine(Flash());   
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
