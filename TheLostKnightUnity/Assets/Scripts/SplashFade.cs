using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour
{
    // Variables
    public Image splashImage;
    public bool isSplashScreen = false;
    Scene currentScene;
    string currentSceneName;
    public bool isDead;
    public bool isTitleScreen;

    void Update()
    {
        if (isDead == true)
        {
            Death();
        }
    }

    IEnumerator Start()
    {
        if (isSplashScreen == true)
        {
            splashImage.canvasRenderer.SetAlpha(0.0f);

            FadeIn();

            yield return new WaitForSeconds(2.5f);

            FadeOut();

            yield return new WaitForSeconds(2.5f);

            SceneManager.LoadScene("Menu");
        }

        if (isTitleScreen == true)
        {
            splashImage.canvasRenderer.SetAlpha(0.0f);

            FadeIn();

            yield return new WaitForSeconds(2.5f);

            FadeOut();

            yield return new WaitForSeconds(2.5f);
            splashImage.enabled = false;
        }
    }

    IEnumerator Death()
    {
        Debug.Log("Here");
        splashImage.canvasRenderer.SetAlpha(0.0f);
        Debug.Log("Here1");

        FadeIn();

        yield return new WaitForSeconds(2.5f);
        Debug.Log("Here2");

        FadeOut();

        yield return new WaitForSeconds(2.5f);
        Debug.Log("Here3");

        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
        SceneManager.LoadScene(currentSceneName);
    }


    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0f, 2.5f, false);
    }

}

