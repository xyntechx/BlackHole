using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TotalCoins : MonoBehaviour
{
    private int coins;
    private int totalcoins;
    public TextMeshProUGUI TotalCoinsText;

    void Start()
    {
        coins = PlayerPrefs.GetInt("CoinsCollected");
        SetTotalCoins(coins);
    }

    public void SetTotalCoins(int addCoins)
    {
        totalcoins = PlayerPrefs.GetInt("TotalCoins", 0);
        PlayerPrefs.SetInt("TotalCoins", (totalcoins + addCoins));
        TotalCoinsText.text = totalcoins.ToString();
    }
}
