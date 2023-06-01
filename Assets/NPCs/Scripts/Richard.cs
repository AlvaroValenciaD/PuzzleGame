using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Richard : MonoBehaviour
{
    [SerializeField, TextArea(1, 1000)] string[] frases;  //Tengo estas frases para escribir en el inspector.
    [SerializeField] GameObject dialogBox;
    [SerializeField] TextMeshProUGUI dialogText;
    int indiceFraseActual = -1;  //Nº de frase actual.
    bool hablando = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InteractuarRichard()
    {
        dialogBox.SetActive(true);
        dialogText.text = "";  //Para que no se superponga un texto con otro
        if (hablando)
        {
            //Autocompletar la frase
            CompletarFraseActual();
        }
        else
        {
            SiguienteFrase();

        }
    }

    IEnumerator EscribirFrase()
    {
        hablando = true;
        char[] fraseTroceada = frases[indiceFraseActual].ToCharArray();

        for (int i = 0; i < fraseTroceada.Length; i++)
        {
            dialogText.text += fraseTroceada[i];
            //Cada letrita de cada frase, ya troceada con su carnicería, aparece en el Canvas; letra por letra.
            yield return new WaitForSeconds(0.05f);
        }

        hablando = false;
    }

    void CompletarFraseActual()
    {
        StopAllCoroutines(); //1. Cállate

        //2. Completa la frase actual 
        dialogText.text = frases[indiceFraseActual];

        //Como completé la fase actual (2.), ya no estoy hablando.
        hablando = false;

        //Para continuar con la siguiente frase hay que parar su reporducción; todas las corrutinas = STOP.
        //A continuación aparece en el Canvas la siguiente frase de todas las que haya.
        //Tenemos que dejar de hablar para dar tiempo a que se reproduzan entre frase y frase.
    }

    void SiguienteFrase()
    {
        indiceFraseActual++; //Avanzo a la siguiente
        if (indiceFraseActual >= frases.Length) //Y Si me pasé (ya no me quedan)...
        {
            dialogBox.SetActive(false); //Desactivo el diálogo
            indiceFraseActual = -1; //Reseteo el contador de frases.

        }
        else
        {
            StartCoroutine(EscribirFrase());
        }
    }
}
