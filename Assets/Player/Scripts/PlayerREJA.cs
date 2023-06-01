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

    [Header("Overlap")]
    [SerializeField] Transform puntoInt;
    [SerializeField] float radioInt;
    [SerializeField] LayerMask interaccionable;

    [SerializeField] GameObject eIcon;
    bool camaraFija = false;


    [Header("Sistema Vital")]
    [SerializeField] float vidas;
    //¿Qué me quita vida?
    //¿Cuánto me quita?
    //Si me quedo sin vidas, ¿qué pasa?  --> Me traslado  --> ¿A dónde?



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
        
        //Movimiento del jugador
        chController.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
        if (h != 0 || v != 0)
        {
            RotateLookDirection();
        }
        
        Gravity();

        Collider[] eColl = Physics.OverlapSphere(puntoInt.position, radioInt, interaccionable);
        if (eColl.Length > 0 && !camaraFija)
        {
            eIcon.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Interactuar();
            }
        }
        else
        {
            //No
            eIcon.SetActive(false);
        }

    }

    void Gravity()
    {
        movementY.y += gravityScale * Time.deltaTime;
        chController.Move(movementY * Time.deltaTime);
    }


    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(puntoInt.position, radioInt);
    }

    void Interactuar()
    {
        Collider[] interactuableCol = Physics.OverlapSphere(puntoInt.position, radioInt, interaccionable);
        if (interactuableCol.Length>0)
        {
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
            else if (interactuableCol[0].CompareTag("AmaDeLlaves"))
            {
                interactuableCol[0].GetComponent<Ama_Llaves>().InteractuarAmaLlaves();
            }
            else if (interactuableCol[0].CompareTag("Objeto"))
            {

            }
            else if (interactuableCol[0].CompareTag("Puzzle"))
            {
                interactuableCol[0].GetComponent<PuzzleTrigger>().ActivePuzzle();
            }
            else if (interactuableCol[0].CompareTag("CamChange"))
            {
                interactuableCol[0].GetComponent<CamChange>().CameraChangeOn();
                //Cursor.lockState = CursorLockMode.None;
                camaraFija = true;
                moveSpeed = 0;
            }
        }
    }

    void RotateLookDirection()
    {
        float ang = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, ang, 0);
    }


}
