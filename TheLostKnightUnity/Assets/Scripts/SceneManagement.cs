using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject LevelChooser;

    void Start()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        LevelChooser.SetActive(false);
    }

    public void StartTutorial()
    {
		SceneManager.LoadScene("Tutorial");
    }

       public void StartLevel1()
    {
		SceneManager.LoadScene("Tutorial");
    }

       public void StartLevel2()
    {
		SceneManager.LoadScene("Tutorial");
    }

       public void StartLevel3()
    {
		SceneManager.LoadScene("Tutorial");
    }

       public void StartLevel4()
    {
		SceneManager.LoadScene("Tutorial");
    }

    public void ChooseLevel()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        LevelChooser.SetActive(true);
    }

    public void OpenOptions()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }

    public void ReturnToMenu()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        LevelChooser.SetActive(false);
    }
    public void ExitGame()
    {
		Application.Quit();    
	}
}