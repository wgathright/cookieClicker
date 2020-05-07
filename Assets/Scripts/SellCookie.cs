using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SellCookie : MonoBehaviour
{

    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int generateTone;


    public void ClickTheButton()
    {
        generateTone = UnityEngine.Random.Range(1, 3);
        if (GlobalCookies.cookieCount > 0)
        {
            if (generateTone == 1)
            {
                cashOne.Play();
            }
            else if (generateTone == 2)
            {
                cashTwo.Play();
            }
            else
            {
                cashOne.Play();
            }
            GlobalCookies.cookieCount -= 1;
            GlobalCash.cashCount += 1;

        }
        else
        {
            statusBox.GetComponent<Text>().text = "Not enough cookies to sell...";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
    }

}
