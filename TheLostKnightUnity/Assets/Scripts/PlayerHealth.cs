using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{

    // Variables
    Image healthBarImage;

    public float playerMaxHealth = 100;
    public float playerHealth;
    float healthPercentage;
    private GameObject deathDisplay;

    private CollisionDamage collisionDamage;

    // Use this for initialization
    void Start()
    {
        GameObject healthBarObject = GameObject.FindGameObjectWithTag("HealthBar");

        playerHealth = playerMaxHealth;

        healthBarImage = healthBarObject.GetComponent<Image>();
        deathDisplay = GameObject.FindGameObjectWithTag("DeathMenu");


        collisionDamage = FindObjectOfType<CollisionDamage>();
        Debug.Log(deathDisplay);
    }

    // Update is called once per frame
    void Update()
    {
        if (deathDisplay == null)
        {
            deathDisplay = GameObject.FindGameObjectWithTag("DeathMenu");
            Debug.Log("Found death menu");

        }

        healthPercentage = playerHealth / playerMaxHealth;
        healthBarImage.fillAmount = healthPercentage;

        if (playerHealth <= 0)
        {
            Debug.Log(deathDisplay);
            Time.timeScale = 0f;
            if (deathDisplay != null)
            {
                deathDisplay.SetActive(true);
            }
        }
    }

}
