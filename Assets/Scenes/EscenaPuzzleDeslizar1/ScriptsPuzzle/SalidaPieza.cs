using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalidaPieza : MonoBehaviour
{

    Item llave;

    // Start is called before the first frame update
    void Start()
    {
        llave = GetComponent<Item>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PiezaPrincipal"))
        {
            SceneManager.LoadScene(2);
            Instantiate(llave);
            //Intancia una llave en la escena.
        }
    }
}
