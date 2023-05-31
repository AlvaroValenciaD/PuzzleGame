using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Balanza : MonoBehaviour
{
    [SerializeField] CanvasManagerPuzzleCocina canvas;

    float total = 0;
    List<GameObject> listadoCapsulas = new List<GameObject>();

    public void Pesar()
    {
        total = 0;
        for (int i = 0; i < listadoCapsulas.Count; i++)
        {
            total += listadoCapsulas[i].GetComponent<CapsulaBuena>().GetPeso();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        listadoCapsulas.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        listadoCapsulas.Remove(other.gameObject);
    }

    public float GetTotal()
    {
        return total;
    }

}
