using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);
        
        GlobalCash.cashCount -= GlobalBaker.bakerValue;
        GlobalBaker.bakerValue *= 2;
        GlobalBaker.turnOffButton = true;
    }
}
