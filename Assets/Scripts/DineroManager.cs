using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    public UIManager uiManager;
}
    public void UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //impedir compra
        }
        else
        {
            playerMoney += amount;
        UIManager.UpdateMoneyUI(playermoney)
        }
    }
}
