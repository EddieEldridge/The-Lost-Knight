using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    // Variables
    float timeBetweenAttack;
    public float startTimeBetweenAttack;

    public Transform attackPosition;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    public bool isAttacking;

    // Shooting Variables
    public GameObject arrowPrefab;
    public float fireDelay = 0.1f;
    float cooldownTimer = 0;
    int arrowLayer;
    float offset = 5;
    public bool isFiring;

    private TextDisplay textDisplay;

    private Animation attackAnim;


    void Start()
    {
        attackAnim = gameObject.GetComponent<Animation>();
        arrowLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (textDisplay == null)
        {
            textDisplay = FindObjectOfType<TextDisplay>();
        }

        // Shooting script
        if (textDisplay != null)
        {
            if (isFiring == true && cooldownTimer <= 0 && textDisplay.arrowAmount > 0)
            {
                textDisplay.arrowAmount -= 1;

                // Set delay in between shots
                cooldownTimer = fireDelay;

                // Create instance of bulletPrefab every time player 'fires'
                GameObject arrowGO = (GameObject)Instantiate(arrowPrefab, transform.position + (offset * transform.forward), Quaternion.identity);
                arrowGO.layer = arrowLayer;
            }
        }


        // Melee attacking script
        if (timeBetweenAttack <= 0)
        {
            if (isAttacking == true)
            {
                Handheld.Vibrate();
                attackAnim.Play();
                timeBetweenAttack = startTimeBetweenAttack;
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsEnemies);

                // For loop 
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<CollisionDamage>().takeDamage(damage);
                    Debug.Log("Damage dealt to player: " + damage);
                }
                timeBetweenAttack = startTimeBetweenAttack;
            }

        }

        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPosition.position, attackRange);
    }
}
