using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerREJA: MonoBehaviour
{
    [SerializeField] GameManagerSO gM;
    [Header("Movimiento")] 
    CharacterController chController;
    [SerializeField] float moveSpeed;[SerializeField] float gravityScale;
    Vector3 moveDirection; Vector3 movementY;
    float h, v;

    bool shouldSpawn = false;
    Vector3 spawnPosition;
    //[Header("Puertas")]
    //[SerializeField] LayerMask whatIsDoor;[SerializeField] float radiusDoor;[SerializeField] GameObject doorPoint;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;

    }

    void Start()
    {
        chController = GetComponent<CharacterController>();
        //Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        if (!shouldSpawn)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");

            // Multiplicamos *(-45) gardos para que tenga un movimiento coherente con el input de teclas
            moveDirection = Quaternion.Euler(0, -45, 0) * new Vector3(h, 0, v);
        
            chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
            Gravity();
        }

    }

    private void LateUpdate()
    {
        if(shouldSpawn)
        {
            Debug.Log("Me recolocan");
            transform.position = spawnPosition;
            shouldSpawn = false;
        }
    }
    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }


    private void SceneManager_sceneLoaded(Scene escenaCargada, LoadSceneMode sceneMode)
    {
        Debug.Log("Nueva escena!");
        if (gM.GetIndexPuertaObjetivo() == -1) return;

        Door[] doors = FindObjectsOfType<Door>();
        foreach (Door door in doors)
        {
            if (door.GetIndexDoor() == gM.GetIndexPuertaObjetivo())
            {
                //Debug.Log("Vete a la puerta " + door.GetIndexDoor() + " de la escena " + escenaCargada.name);
                //transform.position = door.GetSpawnPoint().position;
                spawnPosition = door.GetSpawnPoint().position;
                //transform.eulerAngles = door.GetSpawnRotation();
                
                shouldSpawn = true;
                break;
            }
        }
    }

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(doorPoint.transform.position, radiusDoor);
    }

}
