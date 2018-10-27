using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    // Variables
    [SerializeField] public float moveSpeed;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomSpot;
    private Transform playerTransform;
    public float aggroRange;




    public bool isPatrolling;
    public bool isChasing;

    void Awake()
    {

    }

    void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        isPatrolling = true;
        isChasing = false;
    }

    void Update()
    {
        if (playerTransform == null)
        {
            playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

        // By default the enemies should just patrol the area
        EnemyPatrol();
        if (playerTransform != null)
        {
            if (Vector2.Distance(transform.position, playerTransform.position) < aggroRange)
            {
                EnemyChase();
            }
        }
    }



    void EnemyChase()
    {
        if (playerTransform != null)
        {
            isChasing = true;
            transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, moveSpeed * Time.deltaTime);
        }
    }

    void EnemyPatrol()
    {
        if (isPatrolling == true && isChasing == false)
        {
            if (playerTransform != null)
            {
                transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, moveSpeed * Time.deltaTime);

                if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
                {
                    if (waitTime <= 0)
                    {
                        randomSpot = Random.Range(0, moveSpots.Length);
                        waitTime = startWaitTime;
                    }
                    else
                    {
                        waitTime -= Time.deltaTime;
                    }
                }
            }

        }

    }
}
