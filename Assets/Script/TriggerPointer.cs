using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPointer : MonoBehaviour
{
    private GeneratorLeval _generatorLeval;

    public void Awake()
    {
        _generatorLeval = FindObjectOfType<GeneratorLeval>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _generatorLeval.CreateIamges(transform.parent);
            Destroy(gameObject);
        }
    }

    public void CreateButton()
    {
        _generatorLeval.CreateIamges(transform.parent);
    }
}