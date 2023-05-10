using System; //CUIDADO!!! Librer�a necesaria para poder disparar eventos (los tipo Action)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject --> POO (Clase). No es un gameObject (no hay transform)
//Es un script "convencional" (Como antes de que aprendieras programaci�n espec�fica de Unity).
//Es decir, s�lo se manejan m�todos, variables, for, arrays, etc, pero no Transform, AddForce, etc.
[CreateAssetMenu(menuName = "My Assets/Game Manager")]
public class GameManagerSO : ScriptableObject
{

    //Creo el "Evento" (Action) que se va a disparar cuando baje la vida.
    public event Action<Transform> OnSceneChange;

    Vector3 posicionOrigenGuardada = new Vector3(0, 1.8f, -27);
    Vector3 posicionDestinoGuardada;
    //M�todo llamado desde Player.
    public void GuardarPosicionOrigen(Transform savePosition)
    {
        posicionOrigenGuardada = savePosition.position;

        //Y disparo el evento de que nos han bajado vida
        //para que los suscriptores hagan algo al respecto.
        
            
        //OnDecreaseHealth?.Invoke(vidas);
    }
    public Vector3 CargarPosicionOrigen()
    {
        return posicionOrigenGuardada;
    }

    public void GuardarPosicionDestino(Transform savePosition)
    {
        posicionDestinoGuardada = savePosition.position;

        //Y disparo el evento de que nos han bajado vida
        //para que los suscriptores hagan algo al respecto.


        //OnDecreaseHealth?.Invoke(vidas);
    }
    public Vector3 CargarPosicionDestino()
    {
        return posicionDestinoGuardada;
    }
}
