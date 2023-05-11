using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameManagerSO gM;

    [Header("Escena actual")]
    [SerializeField] int indexDoor;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Vector3 spawnRotation;


    [Header("Escena objetivo")]
    [SerializeField] int indexNextScene;
    [SerializeField] int indexNextDoor;


    public int GetIndexDoor()
    {
        return indexDoor;
    }
    public Transform GetSpawnPoint()
    {
        return spawnPoint;
    }
    public Vector3 GetSpawnRotation()
    {
        return spawnRotation;
    }

    private void OnTriggerEnter(Collider collision)
    {
        gM.CargarEscena(indexNextScene, indexNextDoor);
    }
}
    