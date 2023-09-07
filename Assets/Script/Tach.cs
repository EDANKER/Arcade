using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tach : MonoBehaviour
{
    private Vector3 tachPosition;
    private Rigidbody2D _rigidbody2D;
    public Vector3 discription;
    private float moveSpeed = 10f;

    private static GameObject go;

    public void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Update()
    { 
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("Hello");
            var touch = Input.GetTouch(0);
            tachPosition = Camera.main.ScreenToWorldPoint(touch.position);
            tachPosition.z = 0;
            discription = (tachPosition - transform.position);
            _rigidbody2D.velocity = new Vector2(discription.x, discription.y) * moveSpeed;

            if (touch.phase == TouchPhase.Ended)
            {
                _rigidbody2D.velocity = Vector2.zero;
            }
        }
    }

    public void MouceDown()
    {
        go = gameObject;
    }
}
