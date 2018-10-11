using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour {

	// Variables
	Image healthBar;
	private CollisionDamage damageDetection;

	// Use this for initialization
	void Start () 
	{
		healthBar = GetComponent<Image>();	
		damageDetection = FindObjectOfType<CollisionDamage>();
		damageDetection.maxHealth = damageDetection.health;
	}
	
	// Update is called once per frame
	void Update ()
	{
		healthBar.fillAmount = damageDetection.health / damageDetection.maxHealth;
	}
}
