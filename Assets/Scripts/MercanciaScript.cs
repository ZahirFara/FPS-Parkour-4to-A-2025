using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio = 10;
<<<<<<< HEAD
    public DineroManager dineroManager;

    void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
=======
    public DineroManager DineroManager;

     void Start()
    {
        DineroManager = FindObjectOfType<DineroManager>();
>>>>>>> adeea3542b19aa28b8ac0a1cd76caa4d260ac2ac
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
<<<<<<< HEAD
            //restar precio al dinero del player
            dineroManager.UpdateMoney(-precio);
            Destroy(gameObject);
        } 
=======
            DineroManager.UpdateMoney(precio);
            Destroy(gameObject);
        }
>>>>>>> adeea3542b19aa28b8ac0a1cd76caa4d260ac2ac
    }
}
