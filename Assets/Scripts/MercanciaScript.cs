using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio = 10;
    public DineroManager DineroManager;

     void Start()
    {
        DineroManager = FindObjectOfType<DineroManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DineroManager.UpdateMoney(-precio);
            Destroy(gameObject);
        }
    }
}
