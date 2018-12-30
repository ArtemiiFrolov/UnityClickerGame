using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{

    public int saveGameCash;
    public static int saveValue = 10;
    public GameObject saveButton;
    public GameObject saveText;
    public bool saveAvailable = false;

    void Update()
    {
        saveText.GetComponent<Text>().text = "Cost: $" + saveValue;
        saveGameCash = GlobalCash.CashCount;
        if (saveGameCash >= saveValue)
        {
            var colors = saveButton.GetComponent<Button>().colors;
            colors.normalColor = Color.green;
            saveButton.GetComponent<Button>().colors = colors;
            saveAvailable = true;
        }
        else
        {
            var colors = saveButton.GetComponent<Button>().colors;
            colors.normalColor = Color.red;
            saveButton.GetComponent<Button>().colors = colors;
            saveAvailable = false;
        }
    }

    public void SaveTheGame()
    {
        if (saveAvailable)
        {
            GlobalCash.CashCount -= saveValue;
            PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
            PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
            PlayerPrefs.SetInt("SavedBakers", GlobalBaker.bakePerSec);
            PlayerPrefs.SetInt("SavedShops", GlobalShop.shopPerSec);
            saveValue *= 2;
            PlayerPrefs.SetInt("SaveValue", saveValue);
        }
    }
}
