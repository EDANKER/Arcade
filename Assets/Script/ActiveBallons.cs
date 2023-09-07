using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveBallons : MonoBehaviour
{
    [SerializeField] private GameObject _balloons;
    
    public void Active()
    {
        _balloons.SetActive(false);
    }
}
