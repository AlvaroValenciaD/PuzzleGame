using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManagerPuzzleCocina : MonoBehaviour
{
    [SerializeField] Text textoNumero1, textoNumero2, textoNumero3, textoNumero4, textoNumero5;
    [SerializeField] TextMeshProUGUI peso;
    [SerializeField] Balanza balanza;
    float numCapsulas;

    public void Peso()
    {
        peso.text = balanza.GetTotal().ToString() + " " + "g";
    }

    public void NumSlider1(float numero)
    {
        textoNumero1.text = numero.ToString();
        numCapsulas = numero;
    }
    public void NumSlider2(float numero)
    {
        textoNumero2.text = numero.ToString();
        numCapsulas = numero;
    }
    public void NumSlider3(float numero)
    {
        textoNumero3.text = numero.ToString();
        numCapsulas = numero;
    }
    public void NumSlider4(float numero)
    {
        textoNumero4.text = numero.ToString();
        numCapsulas = numero;
    }
    public void NumSlider5(float numero)
    {
        textoNumero5.text = numero.ToString();
        numCapsulas = numero;
    }

    public float GetNumCapsulas()
    {
        return numCapsulas;
    }
    public void SetNumCapsulas(float nuevo)
    {
        numCapsulas = nuevo;
    }
}
