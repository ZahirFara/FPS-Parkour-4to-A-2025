﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;

    void Start()
    {

    }

    public void UpdateMoneyUI(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}