﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour {

	// Variables
	Image healthBar;
	private PlayerHealth playerHealth;
	private float healthPercentage;

	// Use this for initialization
	void Start () 
	{
		healthBar = GetComponent<Image>();	
		playerHealth = FindObjectOfType<PlayerHealth>();
		playerHealth.maxHealth = playerHealth.health;
	}
	
	// Update is called once per frame
	void Update ()
	{
		healthPercentage = playerHealth.health / playerHealth.maxHealth;
		healthBar.fillAmount = healthPercentage;
	}
}
