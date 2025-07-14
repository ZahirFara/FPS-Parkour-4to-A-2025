using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TMP_Text Money;
    public DineroManager dineroManager;

    public TMP_Text life;
    public HealthManager healthManager;

    // Update is called once per frame
    void Update()
    {
        Money.text = ("Dinero: $" + dineroManager.playerMoney.ToString());
        life.text = ("Vida: " + healthManager.playerHealth.ToString());
    }
}
