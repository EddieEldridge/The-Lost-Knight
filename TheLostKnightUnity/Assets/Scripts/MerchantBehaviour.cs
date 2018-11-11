using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MerchantBehaviour : MonoBehaviour {

	// Variables
	private TextDisplay textDisplay;
	private PlayerMovement player;
	public GameObject tradeBubble;
	private GameObject merchant;
	private GameObject newTradeBubble;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(textDisplay==null)
		{
			textDisplay = FindObjectOfType<TextDisplay>();
		}

		if(player==null)
		{
			player = FindObjectOfType<PlayerMovement>();
		}

		if(merchant==null)
		{
			merchant = GameObject.FindGameObjectWithTag("Merchant");
		}

		if(tradeBubble==null)
		{
			tradeBubble= GameObject.FindGameObjectWithTag("TradeBubble");
		}
	}

	void OnTriggerEnter2D(Collider2D collidingWith)
	{
		if(collidingWith.CompareTag("Player"))
		{
			newTradeBubble = Instantiate(tradeBubble, merchant.transform.position + new Vector3(8,8,20), merchant.transform.rotation);
		}
	}

	void OnTriggerExit2D(Collider2D collidingWith)
	{
		if(collidingWith.CompareTag("Player"))
		{
			Destroy(newTradeBubble);
		}
	}
}
