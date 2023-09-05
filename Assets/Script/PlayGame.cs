using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }
}
