using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour 
{
	// Variables
	public Image splashImage;
	public bool isSplashScreen=false;


	IEnumerator Start()
	{
		splashImage.canvasRenderer.SetAlpha(0.0f);

		FadeIn();

		yield return new WaitForSeconds(2.5f);

		FadeOut();
		
		yield return new WaitForSeconds(2.5f);

		if(isSplashScreen==true)
		{
		 SceneManager.LoadScene("Menu");
		}
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
