using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
<<<<<<< HEAD
    public UIManager uiManager;
}
    public void UpdateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //impedir compra
=======

    public void UpdateMoney(float amount)
    {
   
        if (playerMoney + amount < 0)
        {

>>>>>>> adeea3542b19aa28b8ac0a1cd76caa4d260ac2ac
        }
        else
        {
            playerMoney += amount;
<<<<<<< HEAD
        UIManager.UpdateMoneyUI(playermoney)
        }
=======
        }
   
>>>>>>> adeea3542b19aa28b8ac0a1cd76caa4d260ac2ac
    }
}
