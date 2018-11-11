using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if(collidingWith.CompareTag("Player"))
        {
            SceneManager.LoadScene("CreepingWillow");
        }
    }
}
