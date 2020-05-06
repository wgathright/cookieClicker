using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakerValue;





    void Update()
    {
        currentCash = GlobalCash.cashCount;
        if (currentCash >= 50)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
    }

}
