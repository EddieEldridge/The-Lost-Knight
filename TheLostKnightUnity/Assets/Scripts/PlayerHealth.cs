using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour {

	// Variables
	Image healthBarImage;

    public float playerMaxHealth=100;
    public float playerHealth;
	float healthPercentage;

	private CollisionDamage collisionDamage;

	// Use this for initialization
	void Start () 
	{			
		GameObject healthBarObject = GameObject.FindGameObjectWithTag("HealthBar");

		playerHealth = playerMaxHealth;
		
		healthBarImage = healthBarObject.GetComponent<Image>();
		

		collisionDamage = FindObjectOfType<CollisionDamage>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		healthPercentage = playerHealth / playerMaxHealth;
		healthBarImage.fillAmount = healthPercentage;

		if (playerHealth <= 0)
        {
            Die();
        }
	}

	void Die()
    {
        Destroy(gameObject);
    }
}
