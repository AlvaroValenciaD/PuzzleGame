using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//EN ESTE SCRIPT SE LLEVA LA INTERACCIÓN DEL PLAYER CON LOS DIÁLOGOS HACIA LOS NPCs Y HACIA SÍ MISMO.
public class PlayerInteractionsREJA : MonoBehaviour
{
    [SerializeField] GameManagerSO gM;

    void Start()
    {
        
        
    }

    // Cuando hablo solo
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            gM.ReproducirDialogoActo(0);

        }
    }

}
