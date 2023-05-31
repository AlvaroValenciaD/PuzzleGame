using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerREJA: MonoBehaviour
{
    [Header("Movimiento")] 
    CharacterController chController;
    [SerializeField] float moveSpeed;[SerializeField] float gravityScale;
    Vector3 moveDirection; Vector3 movementY;
    float h, v;
    //[Header("Puertas")]
    //[SerializeField] LayerMask whatIsDoor;[SerializeField] float radiusDoor;[SerializeField] GameObject doorPoint;

    [Header("Overlap")]
    Transform puntoInt;
    float radioInt;
    LayerMask interaccionable;

    [SerializeField] GameObject eIcon;


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
        chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
        Gravity();

        if (Input.GetKeyDown(KeyCode.E))
        {
            Interactuar();
        }

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }


    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(doorPoint.transform.position, radiusDoor);
    }

    void Interactuar()
    {
        Collider[] interactuableCol = Physics.OverlapSphere(puntoInt.position, radioInt, interaccionable);
        
        if (interactuableCol.Length > 0) //¿Estoy tocando algo?
        {
            //Sí
            //¿Qué estoy tocando?
            eIcon.SetActive(true);
            if (interactuableCol[0].CompareTag("Richard"))
            {
                interactuableCol[0].GetComponent<Richard>().InteractuarRichard();
            }
            else if (interactuableCol[0].CompareTag("Phillip"))
            {
                interactuableCol[0].GetComponent<Phillip>().InteractuarPhillip();
            }
            else if (interactuableCol[0].CompareTag("Mayordomo"))
            {
                interactuableCol[0].GetComponent<Mayordomo>().InteractuarMayordomo();
            }
            else if (interactuableCol[0].CompareTag("Cocinero"))
            {
                interactuableCol[0].GetComponent<Cocinero>().InteractuarCocinero();
            }
            else if (interactuableCol[0].CompareTag("Ama de Llaves"))
            {
                interactuableCol[0].GetComponent<Ama_Llaves>().InteractuarAmaLlaves();
            }
        }
        else
        {
            //No
            eIcon.SetActive(false);
        }
    }


}
