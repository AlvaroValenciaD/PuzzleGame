using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//EN ESTE SCRIPT SE LLEVA LA INTERACCI�N DEL PLAYER CON LOS DI�LOGOS HACIA LOS NPCs Y HACIA S� MISMO.
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
