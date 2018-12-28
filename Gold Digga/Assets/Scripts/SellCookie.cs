using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour {

    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton()
    {
        if (GlobalCookies.CookieCount <= 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough cookies";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else {
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
        
    }

}
