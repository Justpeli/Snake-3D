using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothSpeed = 0.25f;
    

    
    public void AddTargetReference(GameObject SnakeHead)
    {
        _target = SnakeHead;
    }


    void Update()
    {
        if (_target!=null)
        {
            Vector3 desiredPosition = _target.transform.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(_target.transform);
        }
       
    }
}
