using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tach : MonoBehaviour
{
    private float deltaX, deltaY;
    private Rigidbody2D _rigidbody2D;
    private bool move = false;
     
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
         PhysicsMaterial2D material2D = new PhysicsMaterial2D();
        material2D.bounciness = 0.75f;
        material2D.friction = 0.4f;
        GetComponent<CircleCollider2D>().sharedMaterial = material2D;
    }

    private void Update()
    { 
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;

                        move = true;

                        _rigidbody2D.freezeRotation = true;
                        _rigidbody2D.velocity = new Vector2(0, 0);
                        _rigidbody2D.gravityScale = 0;
                        GetComponent<CircleCollider2D>().sharedMaterial = null;
                    }

                    break;
                
                case TouchPhase.Moved:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && move)
                    {
                        _rigidbody2D.MovePosition(new Vector2(touchPos.x -deltaX, touchPos.y - deltaY));
                    }
                    break;
                
                case TouchPhase.Ended:
                    move = false;
                    _rigidbody2D.freezeRotation = false;
                    _rigidbody2D.gravityScale = 2;
                    PhysicsMaterial2D material2D = new PhysicsMaterial2D();
                    material2D.bounciness = 0.75f;
                    material2D.friction = 0.4f;
                    GetComponent<CircleCollider2D>().sharedMaterial = material2D;
                    break ;
            }
        }
    }
}
