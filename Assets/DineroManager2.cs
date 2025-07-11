using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager2 : MonoBehaviour
{
    public float playerMoney;
    public UIManager2 manager;

        public bool UpdateMoney (float amount)
    {
        if (playerMoney + amount < 0)
        {
            manager.UpdateHealthText(0);
            return false;
        }
         else
        {
            playerMoney += amount;
            manager.UpdateHealthText(playerMoney);
            return true;
        }
    }
}
 

    
 
    
