using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplay : MonoBehaviour {

	// Variables
	public float coinAmount;
	public Text coinText;
	private ItemCount itemCount;

	  void Start()
    {
         itemCount = FindObjectOfType<ItemCount>();
	}
	// Update is called once per frame
	void Update () 
	{
		coinText.text = "Coins: " + coinAmount;
	}
}
