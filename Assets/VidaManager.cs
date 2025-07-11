using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaManager : MonoBehaviour
{
    public float playerVida = 100f;
    public UIManager2 manager;

    public bool UpdateHealth(float amount)
    {
        if (playerVida + amount < 0)
        {
            manager.UpdateHealthText(0f);
            return false;
        }
        else
        {
            playerVida += amount;
            manager.UpdateHealthText(playerVida);
            return true;
        }
    }
}





