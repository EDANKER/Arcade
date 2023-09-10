using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetings : MonoBehaviour
{
    public Slider _slider;
    [SerializeField] private float oldVolume;
    
    private void Start()
    {
        oldVolume = _slider.value;
        if (!PlayerPrefs.HasKey("volume"))
        {
            _slider.value = 1;
        }
    }

    private void Update()
    {
        if (oldVolume != _slider.value)
        {
            PlayerPrefs.SetFloat("volume", _slider.value);
            PlayerPrefs.Save();
            oldVolume = _slider.value;
        }
    }
}