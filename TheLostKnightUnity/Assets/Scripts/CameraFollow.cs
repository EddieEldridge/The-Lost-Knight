using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Variables
    public Vector3 offset;
    private GameObject player;

    void Start()
    {
    }

    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("PlayerPrefab(Clone)");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}

