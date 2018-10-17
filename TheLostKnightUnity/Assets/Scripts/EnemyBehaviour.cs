using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    // Variables
    [SerializeField] public float moveSpeed;
    private float waitTime;
    public float startWaitTime;
    public Transform player;
    public Transform[] moveSpots;
    private int randomSpot;
    



    public bool isPatrolling = true;
    public bool isChasing = false;

    void Start()
    {
        waitTime=startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
    }

    void Update()
    {
        // By default the enemies should just patrol the area
        EnemyPatrol();
    }

    void EnemyChase()
    {
        if (player != null)
        {


        }
    }

    void EnemyPatrol()
    {
        if (isPatrolling == true && isChasing == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, moveSpeed*Time.deltaTime);

            if(Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
            {
                if(waitTime<=0)
                {
                    randomSpot = Random.Range(0, moveSpots.Length);
                    waitTime=startWaitTime;
                }
                else
                {
                    waitTime-=Time.deltaTime;
                }
            }
        }

    }
}
