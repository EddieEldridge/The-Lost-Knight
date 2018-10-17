using UnityEngine;
using System.Collections;

public class TouchMovement : MonoBehaviour
{
    // Variables
    private PlayerMovement player;
    private PlayerAttack playerAttacking;

     void Start()
    {
                player = FindObjectOfType<PlayerMovement>();
                playerAttacking = FindObjectOfType<PlayerAttack>();
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
        playerAttacking.isFiring = true;
    }

     public void RealeaseFireButton()
    {
        playerAttacking.isFiring = false;
    }

    public void AttackButton()
    {
        playerAttacking.isAttacking=true;
    }
    
    public void ReleaseAttackButton()
    {
        playerAttacking.isAttacking=false;
    }

}