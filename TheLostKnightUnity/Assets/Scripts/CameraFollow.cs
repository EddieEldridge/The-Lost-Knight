using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    public float smoothSpeed = 15;

    // Function to move our camera with our target 
    void LateUpdate()
    {
        if(target!=null)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, target.position.y+3, transform.position.z), Time.deltaTime*smoothSpeed);
        }
    }
}
