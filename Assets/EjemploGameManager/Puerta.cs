using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] GameManagerSO gM;

    [Header("Escena actual")]
    [SerializeField] int indexPuerta;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Vector3 spawnRotation;


    [Header("Escena objetivo")]
    [SerializeField] int indexEscenaObjetivo;
    [SerializeField] int indexPuertaObjetivo;


    public int GetIndexPuerta()
    {
        return indexPuerta;
    }
    public Transform GetSpawnPoint()
    {
        return spawnPoint;
    }
    public Vector3 GetSpawnRotation()
    {
        return spawnRotation;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gM.CargarEscena(indexEscenaObjetivo, indexPuertaObjetivo);
    }

    
}
