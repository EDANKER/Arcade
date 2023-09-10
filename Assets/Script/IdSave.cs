using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IdSave : MonoBehaviour
{
    [SerializeField] private int id = 0;

    [SerializeField] private StartHelp _start;

    private void Start()
    {
        var get = PlayerPrefs.GetInt("id");
        var sum = id + get;
        sum++;
        PlayerPrefs.SetInt("id", sum);
    }
}
