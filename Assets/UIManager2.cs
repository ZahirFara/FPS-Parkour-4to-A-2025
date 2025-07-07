using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager2 : MonoBehaviour
{
    public DineroManager2 dineroManager;
    public VidaManager vidaManager;
    public TextMeshProUGUI ContadorDinero;
    public TextMeshProUGUI ContadorVida;
    float Dinero;
    float Vida;

     void Start()
    {
        dineroManager = FindObjectOfType<DineroManager2>();
        vidaManager = FindObjectOfType<VidaManager>();

    }

    private void Update()
    {
        Dinero = dineroManager.playerMoney;
        Vida = vidaManager.playerVida;
        ContadorDinero.text = "Dinero: " + Dinero.ToString(); 
        ContadorVida.text = "Vida: " + Vida.ToString();
    }
}
