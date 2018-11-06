using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeMenu : MonoBehaviour 
{
    // Variables
    public bool wantsToTrade = false;
    public GameObject TradeMenuUI;
    private TextDisplay textDisplay;
    private PlayerHealth playerHealth;


    void Start()
    {
        TradeMenuUI.SetActive(false);
    }
    void Update()
    {
        if(textDisplay==null)
        {
            textDisplay = FindObjectOfType<TextDisplay>();
        }
        if(playerHealth==null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
        }
        if(wantsToTrade==true)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    public void Resume()
    {
        TradeMenuUI.SetActive(false);
        Time.timeScale = 1f;
        wantsToTrade = false;
    }

    public void Pause()
    {
        TradeMenuUI.SetActive(true);
        Time.timeScale = 0f;
        wantsToTrade = true;
    }

    public void ExitShop()
    {
        Resume();
    }

    public void RestoreHealth()
    {
        if(textDisplay.coinAmount>5)
        {
            playerHealth.playerHealth = 100f;
            textDisplay.coinAmount -= 5;
        }
 
    }

    public void SpeedBoost()
    {
        if(textDisplay.coinAmount>5)
        {
        textDisplay.coinAmount -= 50;
        }
    }

    public void DamageBoost()
    {   
        if(textDisplay.coinAmount>5)
        {
        textDisplay.coinAmount -= 50;
        }
    }

    public void AttackSpeed()
    {
        if(textDisplay.coinAmount>5)
        {
        }

    }
    

}
