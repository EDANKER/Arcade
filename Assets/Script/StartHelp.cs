using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartHelp : MonoBehaviour
{
    [SerializeField] private GameObject _mainCanvas;
    [SerializeField] private GameObject _help1;
    [SerializeField] private GameObject _help2;
    [SerializeField] private GameObject _help3;
    [SerializeField] private GameObject _start;
    [SerializeField] private GameObject _fon;

    [SerializeField] private bool _isActive = false;
    private void Update()
    {
        if (!_isActive)
        {
            _isActive = true;
            StartCoroutine(HelpTime());
        }
    }

    IEnumerator HelpTime()
    {
        _help3.SetActive(true);
        yield return new WaitForSeconds(5);
        _help3.SetActive(false);
        _help1.SetActive(true);
        yield return new WaitForSeconds(5);
        _help1.SetActive(false);
        _help2.SetActive(true);
        yield return new WaitForSeconds(5);
        _fon.SetActive(false);
        _start.SetActive(true);
        _mainCanvas.SetActive(false);
    }
}