﻿using UnityEngine;

public class CameraController : MonoBehaviour 
{
    [SerializeField] private BallController target;
    private float offset;       //keep initial distance between cam and ball

    void Awake()
    {
        if(target == null)
            target = FindObjectOfType<BallController>();
        
        offset = transform.position.y - target.transform.position.y;
    }

    void Update() 
    {             
        //move camera smoothly to target height (yTargetPos)
        Vector3 curPos = transform.position;        //get the pos of cam
        curPos.y = target.transform.position.y + offset;        //always maintain distance to the ball
        transform.position = curPos;        //set the pos of cam
    }
}
