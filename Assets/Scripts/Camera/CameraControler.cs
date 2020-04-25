using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/***
 * from : https://www.youtube.com/watch?v=S2mK6KFdv0I
 * 
 * ***/
public class CameraControler : MonoBehaviour
{
    //Target to follow
    public Transform target;

    //Offset from target
    public Vector3 offset;

    private float currentZoom = 10f;
    
    //Add zoom? 
        
    public float pitch = 2f;

    // LateUpdate is called once per frame, just after Update
    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
    }
}
