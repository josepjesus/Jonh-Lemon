using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoins : MonoBehaviour
{
    public static int totalCoins = 0;
    public Text text;
    void Update()
    {
        text.text = "Total Coins: " + totalCoins;
    }
}
