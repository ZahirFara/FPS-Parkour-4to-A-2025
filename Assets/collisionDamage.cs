using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionDamage : MonoBehaviour
{
    public float damage = 10;
    public VidaManager VidaManager;

    void Start()
    {
        VidaManager = FindObjectOfType<VidaManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (VidaManager.UpdateHealth(-damage))
            {
               
                Debug.Log("se pudo");
            }
            else
            {
                Debug.Log("no se pudo");
            }
        }
    }
}

