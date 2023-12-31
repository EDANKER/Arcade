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

    [SerializeField] public int idChec = 0;
    private void Update()
    {
        idChec = PlayerPrefs.GetInt("id");
        if (idChec == 1)
        {
            if (!_isActive)
            {
                _isActive = true;
                StartCoroutine(HelpTime());
            }
        }
        else
        {
            _mainCanvas.SetActive(false);
            _start.SetActive(true);
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