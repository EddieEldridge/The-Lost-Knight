using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject LevelChooser;
    public GameObject SocialMenu;

    [SerializeField]
    Image level1Button;
    [SerializeField]
    Image level2Button;
    [SerializeField]
    Image level3Button;
    [SerializeField]
    Image level4Button;

    Color tempColor;

    void Start()
    {
        MainMenu.SetActive(true);
        SocialMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        LevelChooser.SetActive(false);

        PlayerPrefs.SetInt("weepingClearingUnlocked", 1);

        if (PlayerPrefs.GetInt("weepingClearingUnlocked") != 1)
        {
            //level1Button = GameObject.FindGameObjectWithTag("PlayButton1").GetComponent<Image>();
            tempColor.a = 0.5f;
            tempColor = level1Button.color;
            level1Button.color = tempColor;
        }

        if (PlayerPrefs.GetInt("hallowedCaveUnlocked") != 1)
        {
            //level2Button = GameObject.FindGameObjectWithTag("PlayButton2").GetComponent<Image>();
            tempColor = level2Button.color;
            tempColor.a = 0.3f;
            level2Button.color = tempColor;
        }

        if (PlayerPrefs.GetInt("hallowedCaveUnlocked") != 1)
        {
            //level3Button = GameObject.FindGameObjectWithTag("PlayButton3").GetComponent<Image>();
            tempColor = level3Button.color;
            tempColor.a = 0.3f;
            level3Button.color = tempColor;

        }

        if (PlayerPrefs.GetInt("fallenKnightsLairUnlocked") != 1)
        {
           // level4Button = GameObject.FindGameObjectWithTag("PlayButton4").GetComponent<Image>();
            tempColor = level4Button.color;
            tempColor.a = 0.3f;
            level4Button.color = tempColor;

        }
    }

    public void StartLevel1()
    {
        SceneManager.LoadScene("CreepingWillow");
    }

    public void StartLevel2()
    {
        if (PlayerPrefs.GetInt("weepingClearingUnlocked") == 1)
        {
            SceneManager.LoadScene("WeepingClearing");
        }
    }

    public void StartLevel3()
    {
        if (PlayerPrefs.GetInt("hallowedCaveUnlocked") == 1)
        {
            SceneManager.LoadScene("HallowedCave");
        }
    }

    public void StartLevel4()
    {
        if (PlayerPrefs.GetInt("fallenKnightsLairUnlocked") == 1)
        {
            SceneManager.LoadScene("FallenKnightsLair");
        }
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
        SocialMenu.SetActive(false);
        LevelChooser.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void OpenSocialMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        LevelChooser.SetActive(false);
        SocialMenu.SetActive(true);
    }


}