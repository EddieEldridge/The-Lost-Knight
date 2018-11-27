using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour
{

    // Variables
    public int arrowAmount;
    public static int coinAmount;
    GameObject coinTextGO;
    GameObject arrowTextGO;
    ItemCount itemCount;
    Text coinText;
    Text arrowText;

    // Update is called once per frame
    void Start()
    {
        coinAmount = PlayerPrefs.GetInt("coinAmount");

        coinTextGO = GameObject.FindGameObjectWithTag("CoinText");
        arrowTextGO = GameObject.FindGameObjectWithTag("ArrowText");
        coinText = coinTextGO.GetComponent<Text>();
        arrowText = arrowTextGO.GetComponent<Text>();

        arrowAmount = 10;
        UpdateArrows();
        UpdateCoins();
    }

    public void UpdateCoins()
    {
        coinAmount++;
        PlayerPrefs.SetInt("coinAmount", coinAmount);

        if (coinText.text != null)
        {
            coinText.text = "" + coinAmount;
        }
        else
        {
            return;
        }
    }

    public void UpdateArrows()
    {
        if (arrowText.text != null)
        {
            arrowText.text = "" + arrowAmount;
        }
        else
        {
            return;
        }
    }
}
