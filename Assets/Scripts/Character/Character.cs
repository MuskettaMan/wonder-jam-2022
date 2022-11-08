using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Character : MonoBehaviour, IControllable
{
    [SerializeField]
    private float _moveSpeed = 2;
    
    private Rigidbody2D _rigidbody;

    public Vector2 Direction => _rigidbody.velocity.normalized;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2Int direction)
    {
        Vector2 velocity = ((Vector2)direction).normalized * _moveSpeed;
        _rigidbody.velocity =  velocity;
    }
}