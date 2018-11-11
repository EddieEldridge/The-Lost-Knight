using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{

    // Variables
    public bool GameIsPaused = false;
    public GameObject PauseMenuUi;
    Scene currentScene;
    string currentSceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused == true)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }

    public void Resume()
    {
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit()
    {
        Debug.Log("Quitting menu");
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Failure()
    {
      SceneManager.LoadScene(currentSceneName);
    }
    


}
