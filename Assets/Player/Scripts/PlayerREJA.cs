using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerREJA: MonoBehaviour
{
    CharacterController chController;
    [SerializeField] float moveSpeed;
    [SerializeField] int hp;
    Vector3 moveDirection;
    float h, v;
    Vector3 movementY;
    [SerializeField] float gravityScale;
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

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }

}
