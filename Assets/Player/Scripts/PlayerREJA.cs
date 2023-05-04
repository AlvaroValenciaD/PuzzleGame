using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerREJA: MonoBehaviour
{
    [Header("Movimiento")] 
    CharacterController chController;
    [SerializeField] float moveSpeed;
    Vector3 moveDirection;
    float h, v;
    Vector3 movementY;
    [SerializeField] float gravityScale;
    [Header("Puertas")]
    [SerializeField] LayerMask whatIsDoor;[SerializeField] float radiusDoor;[SerializeField] GameObject doorPoint;

    void Start()
    {
        chController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        // Multiplicamos *(-45) gardos para que tenga un movimiento coherente con el input de teclas
        moveDirection = Quaternion.Euler(0, -45, 0) * new Vector3(h, 0, v);
        chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
        Gravity();
        Door();

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }

    void Door()
    {
        Collider[] collDoor = Physics.OverlapSphere(doorPoint.transform.position, radiusDoor, whatIsDoor);
        if (collDoor.Length > 0)
        {
            SceneManager.LoadScene(collDoor[0].GetComponent<Door>().GetNewLvlIndex());
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(doorPoint.transform.position, radiusDoor);
    }

}
