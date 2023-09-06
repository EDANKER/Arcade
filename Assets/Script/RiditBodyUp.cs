using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiditBodyUp : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void FixedUpdate()
    {
        UpRb();
    }

    private void UpRb()
    {
        var speed = 1.5f;
        speed += Time.deltaTime + 0.5f;
        _rigidbody2D.MovePosition(transform.position + Vector3.up * speed);
    }
}