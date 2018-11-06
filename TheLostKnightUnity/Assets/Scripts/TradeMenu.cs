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
    private PlayerAttack playerAttack;
    private PlayerMovement playerMovement;


    void Start()
    {
        TradeMenuUI.SetActive(false);
    }
    void Update()
    {
        if(playerAttack==null)
        {
            playerAttack = FindObjectOfType<PlayerAttack>();
        }
        if(playerMovement==null)
        {
            playerMovement = FindObjectOfType<PlayerMovement>();
        }
        if (textDisplay == null)
        {
            textDisplay = FindObjectOfType<TextDisplay>();
        }
        if (playerHealth == null)
        {
            playerHealth = FindObjectOfType<PlayerHealth>();
        }
        if (wantsToTrade == true)
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
        if (textDisplay.coinAmount >= 5)
        {
            playerHealth.playerHealth = 100f;
            textDisplay.coinAmount -= 5;
        }

    }

    public void SpeedBoost()
    {
        if (textDisplay.coinAmount >= 20)
        {
            playerMovement.moveSpeed = playerMovement.moveSpeed * 1.5f;
            textDisplay.coinAmount -= 20;
        }
    }

    public void DamageBoost()
    {
        if (textDisplay.coinAmount >= 50)
        {
            playerAttack.damage += 20;
            textDisplay.coinAmount -= 50;
        }
    }

    public void BuyArrows()
    {
        if (textDisplay.coinAmount >= 10)
        {
            textDisplay.arrowAmount += 10;
            textDisplay.coinAmount -= 25;
        }

    }


}
