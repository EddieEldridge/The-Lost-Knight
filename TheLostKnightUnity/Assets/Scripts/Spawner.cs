using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Variables
	public GameObject prefabToSpawn;
	
	GameObject objectInstance;
	public float respawnDelay;
	public float spawnDelay;
	float timer;

	// Use this for initialization
	void Start () 
	{
		Spawn();
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer+=Time.deltaTime;

		if(objectInstance == null)
		{
			if(timer >= spawnDelay)
			{
				Spawn();
			}
		}
	}

	void Spawn()
	{		
			objectInstance = (GameObject)Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
	}
}
