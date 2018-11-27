using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{

    // Variables
    Image healthBarImage;


    public float playerMaxHealth = 100;
    public float playerHealth;
    float healthPercentage;
    public GameObject UI;
    public GameObject deathText;
    private SplashFade splashFade;
    Scene currentScene;
    string sceneName;



    private CollisionDamage collisionDamage;

    void Awake()
    {
        deathText.SetActive(false);
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
}
    // Use this for initialization
    void Start()
    {
        GameObject healthBarObject = GameObject.FindGameObjectWithTag("HealthBar");

        splashFade = FindObjectOfType<SplashFade>();
        playerHealth = playerMaxHealth;

        healthBarImage = healthBarObject.GetComponent<Image>();

        collisionDamage = FindObjectOfType<CollisionDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        healthPercentage = playerHealth / playerMaxHealth;
        healthBarImage.fillAmount = healthPercentage;

        if (playerHealth <= 0)
        {
            if (UI != null)
            {
                splashFade.isDead = true;
                UI.SetActive(false);
                deathText.SetActive(true);
                SceneManager.LoadScene(sceneName);
            }
        }
    }

}
