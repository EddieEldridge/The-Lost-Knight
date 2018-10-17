using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour {

    
    // Variables
    int correctLayer;
    public int damageDealt;
    float invincibilityTime; 
    public float timer;

    public Color colorToTurn;
    public Color normalColor;
    
    SpriteRenderer spriteRenderer;
    private PlayerHealth playerHealth;
    private EnemyHealth enemyHealth;
    private CameraShake cameraShake;

    public GameObject bloodFX;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        enemyHealth = FindObjectOfType<EnemyHealth>();
        cameraShake = FindObjectOfType<CameraShake>();

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

    void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if(collidingWith.CompareTag("Enemy"))
        {
            StartCoroutine(Flash());   
            enemyHealth.enemyHealth -= damageDealt;
            Debug.Log("Damage Dealt to Enemy: " + damageDealt);
        }

        if(collidingWith.CompareTag("Player"))
        {
            StartCoroutine(Flash());   
            playerHealth.playerHealth -= damageDealt;
            Debug.Log("Damage Dealt to Player: " + damageDealt);
        }  
    }

    void Update()
    {
      
    }

    public void takeDamage(int damageDealt)
    {
       cameraShake.shakeCamera();
       Instantiate(bloodFX, transform.position, Quaternion.identity);
       enemyHealth.enemyHealth-=damageDealt;
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

    void Timer()
    {
    }
}
