using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour
{

    // Variables
    public int arrowAmount;
    public int prefsCoinAmount;
    GameObject coinTextGO;
    GameObject arrowTextGO;
    ItemCount itemCount;
    Text coinText;
    Text arrowText;

    // Update is called once per frame
    void Start()
    {
        prefsCoinAmount = PlayerPrefs.GetInt("coinAmount");

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
        prefsCoinAmount++;
        PlayerPrefs.SetInt("coinAmount", prefsCoinAmount);

        if (coinText.text != null)
        {
            coinText.text = "" + prefsCoinAmount;
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
