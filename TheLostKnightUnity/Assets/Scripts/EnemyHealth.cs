using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	// Variables
    public int enemyMaxHealth=100;
    public int enemyHealth;

	private CollisionDamage collisionDamage;

	// Use this for initialization
	void Start () 
	{	
		enemyMaxHealth = enemyHealth;
		collisionDamage = FindObjectOfType<CollisionDamage>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (enemyHealth <= 0)
        {
            Die();
        }
	}

	void Die()
    {
        Destroy(gameObject);
    }
}
