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
        if (playerAttack == null)
        {
            playerAttack = FindObjectOfType<PlayerAttack>();
        }
        if (playerMovement == null)
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
        if (TextDisplay.coinAmount >= 5)
        {
            playerHealth.playerHealth = 100f;
            TextDisplay.coinAmount -= 5;
            PlayerPrefs.SetInt("coinAmount", TextDisplay.coinAmount);
            textDisplay.UpdateCoins();
        }

    }

    public void SpeedBoost()
    {
        if (textDisplay != null)
        {
            Debug.Log("in");
            if (TextDisplay.coinAmount >= 20)
            {
                playerMovement.moveSpeed = playerMovement.moveSpeed * 1.5f;
                TextDisplay.coinAmount -= 20;
                PlayerPrefs.SetInt("coinAmount", TextDisplay.coinAmount);
                textDisplay.UpdateCoins();

            }
        }

    }

    public void DamageBoost()
    {
        if (TextDisplay.coinAmount >= 50)
        {
            playerAttack.damage += 20;
            TextDisplay.coinAmount -= 50;
            PlayerPrefs.SetInt("coinAmount", TextDisplay.coinAmount);
            textDisplay.UpdateCoins();
        }
    }

    public void BuyArrows()
    {

        if (TextDisplay.coinAmount >= 10)
        {
            textDisplay.arrowAmount += 10;
            TextDisplay.coinAmount -= 25;
            PlayerPrefs.SetInt("coinAmount", TextDisplay.coinAmount);
            textDisplay.UpdateArrows();
            textDisplay.UpdateCoins();
        }

    }


}
