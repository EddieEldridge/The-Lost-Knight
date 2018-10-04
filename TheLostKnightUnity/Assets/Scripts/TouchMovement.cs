using UnityEngine;
using System.Collections;

public class TouchMovement : MonoBehaviour
{
    // Variables
    private PlayerMovement player;
    private Rigidbody2D rigidbody;
    private PlayerShooting playerShooting;

     void Start()
    {
                player = FindObjectOfType<PlayerMovement>();
                playerShooting = FindObjectOfType<PlayerShooting>();
    }

    public void LeftArrow()
    {
        player.moveRight = false;
        player.moveLeft = true;
    }
    
    public void RightArrow()
    {
        player.moveRight = true;
        player.moveLeft = false;
    }
            
    public void ReleaseLeftArrow()
    {
        player.moveLeft = false;
    }
    
    public void ReleaseRightArrow()
    {
        player.moveRight = false;
    }

	public void UpArrow()
	{
		player.jump = true;
	}
    
    public void ReleaseUpArrow()
    {
        player.jump = false;
    }

    public void FireButton()
    {
        playerShooting.isFiring = true;
    }

     public void RealeaseFireButton()
    {
        playerShooting.isFiring = false;
    }
}