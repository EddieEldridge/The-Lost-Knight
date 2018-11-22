using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;


public class Social : MonoBehaviour
{

	
	  private void Awake()
    {
        if (!FB.IsInitialized)
        {
            FB.Init(() =>
            {
                if (FB.IsInitialized)
                    FB.ActivateApp();
                else
                    Debug.LogError("Couldn't initialize");
            },
            isGameShown =>
            {
                if (!isGameShown)
                    Time.timeScale = 0;
                else
                    Time.timeScale = 1;
            });
        }
        else
            FB.ActivateApp();
    }
 
    #region Login / Logout
    public void FacebookLogin()
    {
        var permissions = new List<string>() { "public_profile", "email", "user_friends" };
        FB.LogInWithReadPermissions(permissions);
    }
 
    public void FacebookLogout()
    {
        FB.LogOut();
    }
    #endregion
 
    public void FacebookShare()
    {
        FB.ShareLink(new System.Uri("https://play.google.com/store/apps/details?id=com.EddiEldridge.TheLostKnightAndroid"), "Check it out!",
            "Check out this awesome game!",
            new System.Uri("https://raw.githubusercontent.com/EddieEldridge/The-Lost-Knight/master/Documentation/img/TheLostKnight.png"));
    }
 
    #region Inviting
    public void FacebookGameRequest()
    {
        FB.AppRequest("Hey! Come and play this awesome game! https://play.google.com/store/apps/details?id=com.EddiEldridge.TheLostKnightAndroid", title: "The Lost Knight");
    }
 
    public void FacebookInvite()
    {
        FB.Mobile.AppInvite(new System.Uri("https://play.google.com/store/apps/details?id=com.EddiEldridge.TheLostKnightAndroid"));
    }
    #endregion
 
  


}
