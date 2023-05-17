using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] Text textoNumero;
    [SerializeField] TextMeshProUGUI peso;
    public void NumSlider(float numero)
    {
        textoNumero.text = numero.ToString();
    }

    public void Pesar()
    {

    }
}
