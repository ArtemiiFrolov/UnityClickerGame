using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour {

    public GameObject realButton;
    public GameObject realText;
    public static int shopValue = 15;
    public int currentCash;
    public GameObject shopStats;
    public static int numberOfShops;
    public static int shopPerSec;
    

    private void Update()
    {
        currentCash = GlobalCash.CashCount;
        realText.GetComponent<Text>().text = "Buy shops - $" + shopValue;
        shopStats.GetComponent<Text>().text = "Shops: " + numberOfShops + " @ " + shopPerSec + " Per Second";
        if (currentCash >= shopValue)
        {
            var colors = realButton.GetComponent<Button>().colors;
            colors.normalColor = Color.green;
            realButton.GetComponent<Button>().colors = colors;
        }
        else
        {
            var colors = realButton.GetComponent<Button>().colors;
            colors.normalColor = Color.red;
            realButton.GetComponent<Button>().colors = colors;
        }
    }
}
