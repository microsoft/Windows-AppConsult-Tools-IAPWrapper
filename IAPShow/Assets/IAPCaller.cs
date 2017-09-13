using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class IAPCaller : MonoBehaviour
{
    [DllImport("IAPWrapper")]
    extern static IntPtr Purchase(string storeID);
    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        TaskOnClick();
    }
     void TaskOnClick()
    {
        Purchase("9pjp4testztd");
        Debug.Log("You have clicked the mouse!");
    }
}
