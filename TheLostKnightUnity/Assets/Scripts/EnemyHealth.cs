using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	// Variables
    public int maxHealth=100;
    public int health;

	private CollisionDamage collisionDamage;

	// Use this for initialization
	void Start () 
	{	
		maxHealth = health;
		collisionDamage = FindObjectOfType<CollisionDamage>();
	}
	
	// Update is called once per frame
	void Update () 
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
}
