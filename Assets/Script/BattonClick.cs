using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BattonClick : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;
    [SerializeField] private GameObject _money;
    [SerializeField] private GameObject _ballonBlue;
    [SerializeField] private GameObject _ballonOranje;
    [SerializeField] private GameObject _ballonRed;

    [SerializeField] private AudioSource _audioSource;

    public void ClickRandomBlue()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);
        
        if (randomMoney == 8 || randomMoney == 4)
        {
            _money.SetActive(true);
            _audioSource.Play();
            _ballonBlue.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _audioSource.Play();
            _ballonBlue.SetActive(false);
        }

        else
        {
            _audioSource.Play();
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
            _audioSource.Play();
            _ballonOranje.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _audioSource.Play();
            _ballonOranje.SetActive(false);
        }

        else
        {
            _audioSource.Play();
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
            _audioSource.Play();
            _ballonRed.SetActive(false);
        }

        else if (randomBomb == 1)
        {
            _bomb.SetActive(true);
            _audioSource.Play();
            _ballonRed.SetActive(false);
        }

        else
        {
            _audioSource.Play();
            _ballonRed.SetActive(false);
        }
    }
}