using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCount : MonoBehaviour
{

    private TextDisplay textDisplay;

    void Start()
    {
        textDisplay = FindObjectOfType<TextDisplay>();
    }

    void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if (collidingWith.CompareTag("Player"))
        {
            textDisplay.coinAmount++;
            Destroy(gameObject);
        }
    }
}
