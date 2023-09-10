using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OneSignalSDK;
public class Push : MonoBehaviour
{
    public void Start()
    {
        OneSignal.Default.Initialize("9e4684e3-89e3-4f71-9193-36b41a77d137");
    }
    
}