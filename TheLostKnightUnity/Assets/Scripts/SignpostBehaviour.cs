using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignpostBehaviour : MonoBehaviour {

	// Variables
	private PlayerMovement player;
	public GameObject textBubble;
	public GameObject signpost;
	private GameObject newTextBubble;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(signpost==null)
		{
			signpost = GameObject.FindGameObjectWithTag("Signpost");
		}

		if(player==null)
		{
			player = FindObjectOfType<PlayerMovement>();
		}

		if(textBubble==null)
		{
			textBubble= GameObject.FindGameObjectWithTag("textBubble");
		}
	}

	void OnTriggerEnter2D(Collider2D collidingWith)
	{
		if(collidingWith.CompareTag("Player"))
		{
			newTextBubble = Instantiate(textBubble, signpost.transform.position + new Vector3(8,8,20), signpost.transform.rotation);
		}
	}

	void OnTriggerExit2D(Collider2D collidingWith)
	{
		if(collidingWith.CompareTag("Player"))
		{
			Destroy(newTextBubble);
		}
	}
}
