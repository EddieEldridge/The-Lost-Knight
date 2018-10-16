using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    // Variables
    [SerializeField] public float moveSpeed;
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

       
    }

    void Update()
    {
        // By default the enemies should just patrol the area
        EnemyPatrol();

         
        
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
