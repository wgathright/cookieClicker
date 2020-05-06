using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{

    public GameObject textBox;
    public GameObject statusBox;


    public void ClickTheButton()
    {
        if (GlobalCookies.cookieCount > 0)
        {
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
