using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mayordomo : MonoBehaviour
{
    [SerializeField, TextArea(1, 1000)] string[] frases;  //Para poner todas las frases desde el Inspector
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

    public void InteractuarMayordomo()
    {
        dialogBox.SetActive(true);
        dialogText.text = "";  //Para que no se superponga un texto con otro
        if (hablando)
        {
            CompletarFraseActual();
            //Autocompletar la frase
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
        StopAllCoroutines();
        dialogText.text = frases[indiceFraseActual];
        hablando = false;
    }

    void SiguienteFrase()
    {
        indiceFraseActual++;
        if (indiceFraseActual >= frases.Length) //Si me paso...
        {
            dialogBox.SetActive(false);
            indiceFraseActual = -1;

        }
        else
        {
            StartCoroutine(EscribirFrase());
        }
    }
}
