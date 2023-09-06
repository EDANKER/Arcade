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

    public void CreateButton()
    {
        _generatorLeval.CreateIamges(transform.parent);
    }
}