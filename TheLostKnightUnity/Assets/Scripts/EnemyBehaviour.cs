using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    // Variables
    [SerializeField] public float moveSpeed;
    [SerializeField] private GameObject pointA;
    [SerializeField] private GameObject pointB;
    [SerializeField] private bool reverseMove = false;
    [SerializeField] private Transform objectToUse;
    [SerializeField] private bool moveThisObject = false;
    private float startTime;
    private float journeyLength;
    private float distCovered;
    private float fracJourney;

    public Transform player;
    public int maxDistance;
    public int minimumDistance;
    public bool isPatrolling=true;
    public bool isChasing=false;

    void Start()
    {
        startTime = Time.time;

        if (moveThisObject)
        {
            objectToUse = transform;
        }
        journeyLength = Vector3.Distance(pointA.transform.position, pointB.transform.position);
    }

    void Update()
    {
        // By default the enemies should just patrol the area
        EnemyPatrol();

        // If we walk into the enemies range, they will chase us
         if(Vector2.Distance(transform.position, player.position) >= minimumDistance)
         {
                EnemyChase();
         }   
        
    }

    void EnemyChase()
    {
        if(player != null)
                {
                    // If the distance between the enemey and the player is greater than our set minimumDistance
                    if(Vector2.Distance(transform.position, player.position) >= minimumDistance)
                    {
                        // Change the enemies state to chasing instead of patrolling
                        isPatrolling=false;
                        isChasing=true;

                        // Rotates the transform to face the player
                        //transform.LookAt(player);
                        // Move towards the player
                        transform.position += transform.forward * moveSpeed * Time.deltaTime;
                    }

                    // If the distance between the enemy and the player is less than our maximum distance
                    if (Vector3.Distance(transform.position, player.position) <= maxDistance)
                    {

                    }
                }
        
    }

    void EnemyPatrol()
    {
        if(isPatrolling==true && isChasing == false)
        {
            isChasing=false;

            // Move enemy back and forth between two points
            distCovered = (Time.time - startTime) * moveSpeed;
            fracJourney = distCovered / journeyLength;

            if (reverseMove)
            {
                objectToUse.position = Vector3.Lerp(pointB.transform.position, pointA.transform.position, fracJourney);
            }

            else
            {
                objectToUse.position = Vector3.Lerp(pointA.transform.position, pointB.transform.position, fracJourney);
            }

            if ((Vector3.Distance(objectToUse.position, pointB.transform.position) == 0.0f || Vector3.Distance(objectToUse.position, pointA.transform.position) == 0.0f)) //Checks if the object has travelled to one of the points
            {
                if (reverseMove)
                {
                    reverseMove = false;
                }
                else
                {
                    reverseMove = true;
                }
                startTime = Time.time;
            }
        }
       
    }
}
