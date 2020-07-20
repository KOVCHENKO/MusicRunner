﻿using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    public Transform target;

    private float _offsetZ;
    
    private void Start()
    {
        _offsetZ = (transform.position).z;

        if (target == null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        if (target == null)
        {
            Debug.LogError("Target shall be set to CameraFollowController");
        }
    }

    private void Update()
    {
        if (target == null) {
            return;
        }

        Vector3 aheadTargetPos = target.position + Vector3.forward * _offsetZ;
        
        // Center camera to the positon of the whole field
        transform.position = new Vector3(aheadTargetPos.x + 3, transform.position.y, aheadTargetPos.z);
    }
}