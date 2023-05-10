using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] int doorIndex;
    [SerializeField] Transform puntoOrigen;
    [SerializeField] Vector3 puntoDestino;

  
    public int GetNewLvlIndex()
    {
        return doorIndex;
    }
    public Transform GetPuntoSpawn()
    {
        return puntoOrigen;
    }
    public Vector3 GetPuntoDestino()
    {
        return puntoDestino;
    }
}
