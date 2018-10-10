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

         
        if(player != null)
        {
            // If the distance between the enemey and the player is greater than our set minimumDistance
            if(Vector3.Distance(transform.position, player.position) >= minimumDistance)
            {
                // Rotates the transform to face the player
                transform.LookAt(player);
                // Move towards the player
                transform.position += transform.forward * moveSpeed * Time.deltaTime;
            }

            // If the distance between the enemy and the player is less than our maximum distance
            if (Vector3.Distance(transform.position, player.position) <= maxDistance)
            {

            }
        }
        
        
    }
   
}
