using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }
}
