using UnityEngine;
using System.Collections;

public class TouchMovement : MonoBehaviour
        {
            private PlayerMovement player;


            void Start()
            {
                player = FindObjectOfType<PlayerMovement>();
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

			public void Jump()
			{
				player.jump=true;
			}

        }