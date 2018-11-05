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
            Debug.Log("TRADING!");
            TradeMenuUI.SetActive(true);
            Pause();
        }
        else
        {

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
        Time.timeScale = 0f;
        wantsToTrade = true;
    }

}
