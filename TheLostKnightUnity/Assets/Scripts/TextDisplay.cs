using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour
{

    // Variables
    public int coinAmount;
    public int arrowAmount;
    public Text coinText;
    public Text arrowText;

    // Update is called once per frame
    void Start()
    {
        arrowAmount=10;
    }

    void Update()
    {
        if(coinText.text!=null)
        {
             coinText.text = "Coins: " + coinAmount;
        }
        else
        {
            return;
        }
        if(arrowText.text!=null)
        {
        arrowText.text = "Arrows: " + arrowAmount;
        }
        else
        {
            return;
        }
    }
}
