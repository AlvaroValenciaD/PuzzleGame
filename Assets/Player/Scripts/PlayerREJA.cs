using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerREJA: MonoBehaviour
{
    [Header("Movimiento")] 
    CharacterController chController;
    [SerializeField] float moveSpeed;[SerializeField] float gravityScale;
    Vector3 moveDirection; Vector3 movementY;
    float angSpeed;
    float h, v;
    //[Header("Puertas")]
    //[SerializeField] LayerMask whatIsDoor;[SerializeField] float radiusDoor;[SerializeField] GameObject doorPoint;


    void Start()
    {
        chController = GetComponent<CharacterController>();
        //Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        // Multiplicamos *(-45) gardos para que tenga un movimiento coherente con el input de teclas
        moveDirection = Quaternion.Euler(0, -45, 0) * new Vector3(h, 0, v);
        if (chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime) != 0)
        {
            chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
            RotateLookDirection();
        }
        
        Gravity();

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }

    void RotateLookDirection()
    {
        float ang = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
        float smoothAng = Mathf.SmoothDampAngle(transform.eulerAngles.y, ang, ref angSpeed, 0.1f);
        transform.eulerAngles = new Vector3(0, smoothAng, 0);
    }


    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(doorPoint.transform.position, radiusDoor);
    }

}
