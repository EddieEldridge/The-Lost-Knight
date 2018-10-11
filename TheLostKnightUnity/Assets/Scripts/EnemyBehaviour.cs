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
   // public int maxDistance;
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
                isPatrolling=false;
                isChasing=true;
                EnemyChase();
         }   
        
    }

    void EnemyChase()
    {
        if(player != null)
                {
                   
                    
                }
        
    }

    void EnemyPatrol()
    {
        if(isPatrolling==true && isChasing == false)
        {
            
        }
       
    }
}
