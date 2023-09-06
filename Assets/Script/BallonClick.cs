using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BallonClick : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;
    [SerializeField] private GameObject _money;
    [SerializeField] private GameObject _ballonBlue;
    [SerializeField] private GameObject _ballonOranje;
    [SerializeField] private GameObject _ballonRed;

    public void ClickRandomBlue()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);
        
        if (randomMoney == 8 || randomMoney == 4)
        {
            _money.SetActive(true);
            _ballonBlue.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _ballonBlue.SetActive(false);
        }

        else
        {
            _ballonBlue.SetActive(false);
        }
    }

    public void ClickRandomOranje()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);
        
        if (randomMoney == 8 || randomMoney == 4)
        {
            _money.SetActive(true);
            _ballonOranje.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _ballonOranje.SetActive(false);
        }

        else
        {
            _ballonOranje.SetActive(false);
        }
    }
    
    public void ClickRandomRed()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);
        
        if (randomMoney == 8 || randomMoney == 4)
        {
            _money.SetActive(true);
            _ballonRed.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _ballonRed.SetActive(false);
        }

        else
        {
            _ballonRed.SetActive(false);
        }
    }
}