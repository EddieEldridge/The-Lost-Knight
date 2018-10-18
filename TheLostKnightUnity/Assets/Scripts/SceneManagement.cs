using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("Play button!");
		SceneManager.LoadScene("Tutorial");
    }

    public void OpenOptions()
    {
        Debug.Log("Options button!");
		SceneManager.LoadScene("Tutorial");
    }

    public void ExitGame()
    {
        Debug.Log("Exit button!");
		Application.Quit();    
	}
}