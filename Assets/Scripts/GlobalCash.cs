using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

    

    public static int cashCount;
    public GameObject cashDisplay;
    public int InternalCash;
   
    void Update()
    {
        

        InternalCash = cashCount;
        cashDisplay.GetComponent<Text>().text = "$" + InternalCash;
        
    }
}
