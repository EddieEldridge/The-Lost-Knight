using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	// Variables
	public bool GameIsPaused = false;
	public GameObject PauseMenuUi;
	
	
	// Update is called once per frame
	void Update () 
	{
		if(GameIsPaused == true)
		{
			Pause();
		}
		else
		{
			Resume();
		}
	}

	void Resume()
	{
		PauseMenuUi.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause()
	{
		PauseMenuUi.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}
}
