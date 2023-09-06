using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeitingsMenu : MonoBehaviour
{
    [SerializeField] private GameObject _canvasMenu;

    public void Menu()
    {
        _canvasMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void MenuExit()
    {
        _canvasMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
