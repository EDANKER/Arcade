using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RidgetBodyBomb : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private void Update()
    {
        _rigidbody2D.MovePosition(transform.position + Vector3.down * 20f);
    }
}
