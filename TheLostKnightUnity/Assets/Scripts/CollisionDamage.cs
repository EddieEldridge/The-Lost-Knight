using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDamage : MonoBehaviour
{


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

    private ParticleSystem particleSystem;

    void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        enemyHealth = FindObjectOfType<EnemyHealth>();
        cameraShake = FindObjectOfType<CameraShake>();

        correctLayer = gameObject.layer;

        spriteRenderer = GetComponent<SpriteRenderer>();

        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();

            if (spriteRenderer == null)
            {
                Debug.Log("Error: No sprite found.");
            }
        }

    }

    void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if (collidingWith.CompareTag("Enemy"))
        {
            Handheld.Vibrate();
            StartCoroutine(Flash());
            enemyHealth.enemyHealth -= damageDealt;
            Debug.Log("Damage Dealt to Enemy: " + damageDealt);
        }

        if (collidingWith.CompareTag("Player"))
        {
            StartCoroutine(Flash());
            playerHealth.playerHealth -= damageDealt;
            Debug.Log("Damage Dealt to Player: " + damageDealt);
        }

    }

    void Update()
    {
        if(playerHealth == null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
        }
    }

    public void takeDamage(int damageDealt)
    {
        Handheld.Vibrate();
        particleSystem.Play();
        cameraShake.shakeCamera();
        enemyHealth.enemyHealth -= damageDealt;
        StartCoroutine(Flash());
    }

    IEnumerator Flash()
    {
        int i;

        // Flash
        for (i = 0; i < 5; i++)
        {
            spriteRenderer.color = colorToTurn;
            yield return new WaitForSeconds(0.05f);
            spriteRenderer.color = normalColor;
            yield return new WaitForSeconds(0.05f);

        }
    }


}
