using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour {

    public GameObject textBox;
    public GameObject statusBox;    
    public int generateTone;
    public AudioSource[] sources;
    public AudioSource noCookie;

    public void ClickTheButton()
    {
        generateTone = Random.Range(0, sources.Length);
        if (GlobalCookies.CookieCount <= 0)
        {
            statusBox.GetComponent<Text>().text = "Not enough cookies";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            noCookie.Play();
        }
        else {
            sources[generateTone].Play();
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
        
    }

}
