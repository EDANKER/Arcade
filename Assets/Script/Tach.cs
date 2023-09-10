using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tach : MonoBehaviour
{
    private Vector2 startPos, endPos, direction;
    private float touchTimeStart, touchTimeFinish, timeInternal;

    [Range(-0.5f, 400f)] public float throwForse = 0.3f;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            touchTimeFinish = Time.time;
            timeInternal = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch(0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody2D>().AddForce(-direction / timeInternal * throwForse);
        }
    }
}