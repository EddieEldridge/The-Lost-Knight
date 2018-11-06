using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TradeMenu : MonoBehaviour 
{
    // Variables
    public bool wantsToTrade = false;
    public GameObject TradeMenuUI;
    

    void Start()
    {
        TradeMenuUI.SetActive(false);
    }
    void Update()
    {
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

    }

    public void SpeedBoost()
    {

    }

    public void DamageBoost()
    {

    }

    public void AttackSpeed()
    {

    }
    

}
