using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {

    // Variables
    public float timer = 1f;
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        if(timer<0)
        {
            Destroy(gameObject);
        }
	}
}
