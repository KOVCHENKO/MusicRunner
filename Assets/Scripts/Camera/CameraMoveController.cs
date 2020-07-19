using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveController : MonoBehaviour
{
    [Range(0.0f, 10.0f)]
    public float moveSpeed = 7f;

    public bool constantMoving = true;
    
    // Preferences to components of gameObject
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
    private Animator _animator;
    
    // Player position
    private float _vx;
    private float _vy;
    
    bool _isMoving = false;
    
  private void Awake()
    {
        _transform = GetComponent<Transform> ();
    }

    void Update()
    {
        // determine horizontal velocity change based on the horizontal input
        _vx = Input.GetAxisRaw ("Horizontal");
        
        if (constantMoving)
        {
            _rigidbody2D.velocity = new Vector2(moveSpeed, 0);
        }
    }
}