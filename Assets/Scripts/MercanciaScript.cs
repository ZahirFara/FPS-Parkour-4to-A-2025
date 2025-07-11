using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public float precio = 10;
    public DineroManager2 dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager2>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (dineroManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
                Debug.Log("se pudo");
            }     
            else {
                Debug.Log("no se pudo");
                 }
        }
    }
}