using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour
{

    // Variables
    public int coinAmount;
    public int arrowAmount;
    [SerializeField]
    public Text coinText;
    [SerializeField]
    public Text arrowText;

    // Update is called once per frame
    void Start()
    {
        arrowAmount = 10;
        UpdateArrows();
        UpdateCoins();
    }

    public void UpdateCoins()
    {
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
