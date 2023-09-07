using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPointer : MonoBehaviour
{
    private GeneratorLeval _generatorLevel;
    private int _num = 0;

    public void Awake()
    {
        _generatorLevel = FindObjectOfType<GeneratorLeval>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _num++;
        Debug.Log(_num);
        if (!other.gameObject.CompareTag("Player") || _num < 2) return;
        _generatorLevel.CreateIamges(transform.parent);
        _num = 0;
    }
}