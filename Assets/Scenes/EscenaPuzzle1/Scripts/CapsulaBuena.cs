using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaBuena : MonoBehaviour
{
    [SerializeField] float peso;
    Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    public float GetPeso()
    {
        return peso;
    }

    private void OnMouseDrag()
    {
        Vector3 posicionRatonJuego = cam.ScreenToWorldPoint(Input.mousePosition);
        posicionRatonJuego.z = -0.5f;
        transform.position = posicionRatonJuego;
    }

    
}
