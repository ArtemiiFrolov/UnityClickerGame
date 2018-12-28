using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour {

    public GameObject realButton;
    public GameObject realText;
    public static int bakerValue = 10;
    public int currentCash;
    public GameObject bakerStats;
    public static int numberOfBakers;
    public static int bakePerSec;
    

    private void Update()
    {
        currentCash = GlobalCash.CashCount;
        realText.GetComponent<Text>().text = "Buy baker - $" + bakerValue;
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberOfBakers + " @ " + bakePerSec + " Per Second";
        if (currentCash >= bakerValue)
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
