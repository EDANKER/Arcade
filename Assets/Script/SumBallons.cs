using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class SumBallons : MonoBehaviour
{
    [SerializeField] public int sum = 0;
    [SerializeField] private TextMeshProUGUI _ugui;

    [SerializeField] private BattonClick _battonClick;

    [SerializeField] private GameObject _vin;

    private void Start()
    {
        _ugui = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        _ugui.text = "" + _battonClick.sumTask;
        if (_battonClick.sumTask == 0)
        {
            _vin.SetActive(true);
        }
    }
}