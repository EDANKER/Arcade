using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDetect : MonoBehaviour
{
    public bool bombActive = false;
    [SerializeField] private bool isActive = false;
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.transform.gameObject.CompareTag("bomb"))
        {
            bombActive = true;
        }
    }
}
