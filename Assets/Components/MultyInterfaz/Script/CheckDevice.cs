using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDevice : MonoBehaviour
{
    public bool window = false;
    public bool andr = false;
    
    void Awake()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            andr = true;
            window = false;
        }
        else if(Application.platform == RuntimePlatform.WindowsPlayer)
        {
            andr = false;
            window = true;
        }
    }
    
}
