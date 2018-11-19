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
    public int prefsCoinAmount;


    void Start()
    {
        prefsCoinAmount=PlayerPrefs.GetInt("coinAmount");
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
        if (prefsCoinAmount >= 5)
        {
            playerHealth.playerHealth = 100f;
            prefsCoinAmount -= 5;
            PlayerPrefs.SetInt("coinAmount", prefsCoinAmount);
            textDisplay.UpdateCoins();

        }

    }

    public void SpeedBoost()
    {
        if (textDisplay != null)
        {
            Debug.Log("in");
            if (prefsCoinAmount >= 20)
            {
                playerMovement.moveSpeed = playerMovement.moveSpeed * 1.5f;
                prefsCoinAmount -= 20;
                PlayerPrefs.SetInt("coinAmount", prefsCoinAmount);
                textDisplay.UpdateCoins();

            }
        }

    }

    public void DamageBoost()
    {
        if (prefsCoinAmount >= 50)
        {
            playerAttack.damage += 20;
            prefsCoinAmount -= 50;
            PlayerPrefs.SetInt("coinAmount", prefsCoinAmount);
            textDisplay.UpdateCoins();

        }
    }

    public void BuyArrows()
    {

        if (prefsCoinAmount >= 10)
        {
            textDisplay.arrowAmount += 10;
            prefsCoinAmount -= 25;
            PlayerPrefs.SetInt("coinAmount", prefsCoinAmount);
            textDisplay.UpdateArrows();
            textDisplay.UpdateCoins();
        }

    }


}
