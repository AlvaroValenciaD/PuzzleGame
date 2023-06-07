using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SistemaDeDialogos : MonoBehaviour
{
    [SerializeField] GameManagerSO gM;
    [SerializeField] GameObject dialogBox;
    [SerializeField] TextMeshProUGUI dialogText;
    int indiceDialogoActual;
    int indiceFraseActual = -1;
   
    bool escribiendo = false;

    private void OnEnable()
    {
        gM.OnReproducirActo += ReproducirDialogo;
    }
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReproducirDialogo(int numeroDialogo)
    {
        indiceDialogoActual = numeroDialogo;
        dialogBox.SetActive(true);
        dialogText.text = "";  
        if (escribiendo)
        {
            CompletarFraseActual();
        }
        else
        {
            SiguienteFrase();

        }
    }

    IEnumerator EscribirFrase()
    {
        escribiendo = true;
        char[] fraseTroceada = gM.dialogos[indiceDialogoActual].frases[indiceFraseActual].ToCharArray();

        for (int i = 0; i < fraseTroceada.Length; i++)
        {
            dialogText.text += fraseTroceada[i];
            //Cada letrita de cada frase, ya troceada con su carnicería, aparece en el Canvas; letra por letra.
            yield return new WaitForSeconds(0.05f);
        }
        yield return null;
        escribiendo = false;
    }

    void CompletarFraseActual()
    {
        StopAllCoroutines();
        dialogText.text = gM.dialogos[indiceDialogoActual].frases[indiceFraseActual];
        escribiendo = false;
    }

    void SiguienteFrase()
    {
        indiceFraseActual++;
        // gM.dialogos[indiceDialogoActual].frases
        if (indiceFraseActual >= gM.dialogos[indiceDialogoActual].frases.Length) //Si me paso...
        {
            dialogBox.SetActive(false);
            indiceFraseActual = -1;

        }
        else
        {
            StartCoroutine(EscribirFrase());
        }
    }


    private void OnDisable()
    {
        gM.OnReproducirActo -= ReproducirDialogo;
    }
}
