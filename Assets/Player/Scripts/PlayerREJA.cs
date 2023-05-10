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
    [Header("Puertas")]
    [SerializeField] LayerMask whatIsDoor;[SerializeField] float radiusDoor;[SerializeField] GameObject doorPoint;


    void Start()
    {
        chController = GetComponent<CharacterController>();
        //Cursor.lockState = CursorLockMode.Locked;
        //transform.position = gM.CargarPosicionOrigen();
    }


    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        // Multiplicamos *(-45) gardos para que tenga un movimiento coherente con el input de teclas
        moveDirection = Quaternion.Euler(0, -45, 0) * new Vector3(h, 0, v);
        chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
        Gravity();

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }


    void SavePosition()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            Door door = other.GetComponent<Door>();
            //gM.GuardarPosicionOrigen(door.GetPuntoSpawn());
            SceneManager.LoadScene(door.GetNewLvlIndex());
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(doorPoint.transform.position, radiusDoor);
    }

}
