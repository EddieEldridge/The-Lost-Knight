using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

     // Variables
    string sceneName;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        sceneName =scene.name;
    }

	void OnTriggerEnter2D(Collider2D collidingWith)
    {
        if(collidingWith.CompareTag("Player") && sceneName=="CreepingWillow")
        {
            SceneManager.LoadScene("WeepingClearing");
            PlayerPrefs.SetInt("weepingClearingUnlocked", 1);
        }

          if(collidingWith.CompareTag("Player") && sceneName=="WeepingClearing")
        {
            SceneManager.LoadScene("HallowedCave");
            PlayerPrefs.SetInt("hallowedCaveUnlocked", 1);
        }

          if(collidingWith.CompareTag("Player") && sceneName=="HallowedCave")
        {
            SceneManager.LoadScene("FallenKnightsLair");
            PlayerPrefs.SetInt("fallenKnightsLairUnlocked", 1);
        }
        
        if(collidingWith.CompareTag("Player") && sceneName=="FallenKnightsLair")
        {
            SceneManager.LoadScene("MainMenu");
            PlayerPrefs.SetInt("fallenKnightsLairUnlocked", 1);
        }
    }
}
