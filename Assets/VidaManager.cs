using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaManager : MonoBehaviour
{
    public float playerVida;

    public bool UpdateHealth(float amount)
    {
        if (playerVida + amount < 0)
        {
            return false;
        }
        else
        {
            playerVida += amount;
            return true;
        }
    }
}





