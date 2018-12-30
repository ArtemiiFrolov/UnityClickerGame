using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int savedCookies;
    public int savedCash;
    public int savedBakers;
    public int savedShops;
    public int savedValue;


    void Start () {
		if (MainMenuOptions.isLoading)
        {
            GlobalCookies.CookieCount = PlayerPrefs.GetInt("SavedCookies");
            GlobalCash.CashCount = PlayerPrefs.GetInt("SavedCash");
            GlobalBaker.bakePerSec = PlayerPrefs.GetInt("SavedBakers");
            GlobalShop.numberOfShops = PlayerPrefs.GetInt("SavedShops");
            SaveGame.saveValue = PlayerPrefs.GetInt("SaveValue");           
        }
	}
	

}
