using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{

    public static int cookieCount;
    public GameObject cookieDisplay;
    public int InternalCookie;

    
   
    void Update()
    {
        InternalCookie = cookieCount;
        cookieDisplay.GetComponent<Text>().text = "Cookies: " + InternalCookie;

        
        
    }
}
