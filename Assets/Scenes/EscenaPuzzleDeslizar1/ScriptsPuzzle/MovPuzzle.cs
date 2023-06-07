using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPuzzle : MonoBehaviour
{
    Collider coll;
    Rigidbody2D rb;
    //[SerializeField] GameManagerSO gM;
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        coll = GetComponent<Collider>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        Vector3 posicionRatonJuego = cam.ScreenToWorldPoint(Input.mousePosition);
        //posicionRatonJuego.z = transform.position.z;
        float dif = (posicionRatonJuego - transform.position).magnitude;
        Vector3 direction = (posicionRatonJuego - transform.position).normalized;
        rb.velocity = direction * dif;
        
    }
    private void OnMouseUp()
    {
        rb.velocity = new Vector3(0, 0, 0);
        rb.bodyType = RigidbodyType2D.Static;
    }

    //Condición de victoria.
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (true)
    //    {
    //        gM.puzzle1Completado = true;
    //    }
    //}
}
