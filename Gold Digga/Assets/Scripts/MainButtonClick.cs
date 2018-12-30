using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

    public GameObject textBox;
    public AudioSource makeCookie;

    public void ClickTheButton()
    {
        GlobalCookies.CookieCount += 1;
        makeCookie.Play();
    }


}
