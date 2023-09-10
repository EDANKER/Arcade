using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class BattonClick : MonoBehaviour
{
    [SerializeField] private GameObject _balloonsBlue;
    [SerializeField] private GameObject _balloonsRed;
    [SerializeField] private GameObject _balloonsOranje;
    [SerializeField] private GameObject _bomb;
    [SerializeField] private GameObject _money;

    [FormerlySerializedAs("sumBallons")] [SerializeField] public int sumTask = 0;

    private TextMeshProUGUI mesh;
    [SerializeField] public int num = 0;

    [SerializeField] private AudioSource audioBalloon;
    [SerializeField] private AudioSource audioMoney;
    [SerializeField] private AudioSource audioTimerBomb;
    [SerializeField] private AudioSource audioBomb;

    [SerializeField] private Animator moneyAnim;
    private static readonly int Drop = Animator.StringToHash("drop");

    [SerializeField] private bool isActive = false;
    [SerializeField] private bool isActiveBomb = false;
    private GeneratorBomb _generator;

    [SerializeField] private GameObject _canvasGameOver;

    [SerializeField] private BombDetect _bombDetects1;
    [SerializeField] private BombDetect _bombDetects2;

    [SerializeField] public int sum;
    
    public void Start()
    {
        var random = Random.Range(10, 30);
        sumTask = random;
        
        mesh = GetComponent<TextMeshProUGUI>();
        _generator = FindObjectOfType<GeneratorBomb>();
    }

    private void Update()
    {
        mesh.text = "" + num;
    }

    public void ActiveBlue()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);

        if (randomMoney == 8 || randomMoney == 4)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            num++;
            moneyAnim.SetBool(Drop, true);
            audioBalloon.Play();
            audioMoney.Play();
            if (!isActive)
            {
                StartCoroutine(Time());
                isActive = true;
            }
        }

        else if (randomBomb == 4)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioTimerBomb.Play();
            audioBalloon.Play();
            _generator.CreateBomb(transform.parent);
            if (!isActiveBomb)
            {
                isActiveBomb = true;
                StartCoroutine(TimeBomb());
            }
        }

        else
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioBalloon.Play();
        }
    }

    public void ActiveOranje()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);

        if (randomMoney == 8 || randomMoney == 4)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            for (int i = 0; i <= 3; i++)
            {
                num++;
            }
            moneyAnim.SetBool(Drop, true);
            audioBalloon.Play();
            audioMoney.Play();
            if (!isActive)
            {
                StartCoroutine(Time());
                isActive = true;
            }
        }

        else if (randomBomb == 3)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioTimerBomb.Play();
            audioBalloon.Play();
            _generator.CreateBomb(transform.parent);
            if (!isActiveBomb)
            {
                isActiveBomb = true;
                StartCoroutine(TimeBomb());
            }
        }

        else
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioBalloon.Play();
        }
    }

    public void ActiveRed()
    {
        var randomBomb = Random.Range(1, 4);
        var randomMoney = Random.Range(2, 8);

        if (randomMoney == 8 || randomMoney == 4)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            for (int i = 0; i <= 5; i++)
            {
                num++;
            }

            moneyAnim.SetBool(Drop, true);
            audioBalloon.Play();
            audioMoney.Play();
            if (!isActive)
            {
                StartCoroutine(Time());
                isActive = true;
            }
        }

        else if (randomBomb == 2)
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioTimerBomb.Play();
            audioBalloon.Play();
            _generator.CreateBomb(transform.parent);
            if (!isActiveBomb)
            {
                isActiveBomb = true;
                StartCoroutine(TimeBomb());
            }
        }

        else
        {
            if (sumTask != 0)
            {
                sumTask--;
            }
            audioBalloon.Play();
        }
    }

    IEnumerator TimeBomb()
    {
        yield return new WaitForSeconds(5);
        if (!_bombDetects1.bombActive && !_bombDetects2.bombActive)
        {
            audioBomb.Play();
            _canvasGameOver.SetActive(true);
            isActiveBomb = false;
        }
    }

    IEnumerator Time()
    {
        yield return new WaitForSeconds(3);
        moneyAnim.SetBool(Drop, false);
        isActive = false;
    }
}