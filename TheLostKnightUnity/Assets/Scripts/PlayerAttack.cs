using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	// Variables
	private float timeBetweenAttack;
	public float startTimeBetweenAttack;

	public Transform attackPosition;
	public LayerMask whatIsEnemies;
	public float attackRange;
	public int damage;

	// Update is called once per frame
	void Update ()
	{
		if(timeBetweenAttack<=0)
		{
			if(Input.GetKey(KeyCode.Space))
			{
				Debug.Log("Player attacking");
				timeBetweenAttack = startTimeBetweenAttack;
				Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPosition.position, attackRange, whatIsEnemies);
				
				// For loop 
				for(int i =0; i < enemiesToDamage.Length; i++)
				{
					Debug.Log("Damage taken by enemy!");
					enemiesToDamage[i].GetComponent<CollisionDamage>().takeDamage(damage);
				}
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
