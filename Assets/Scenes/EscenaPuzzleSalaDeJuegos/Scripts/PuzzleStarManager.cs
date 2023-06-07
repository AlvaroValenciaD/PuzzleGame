using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleStarManager : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI inputTipos;
    [SerializeField] TextMeshProUGUI inputTotal;
    [SerializeField] GameObject acertaste;
    [SerializeField] GameObject fallaste;
    string inputTiposResolve;
    string inputTotalResolve;

    private void Update()
    {
        inputTiposResolve = inputTipos.text;
        inputTotalResolve = inputTotal.text;
        
    }
    public void Resolver()
    {
        Debug.Log(inputTiposResolve + "" + inputTotalResolve);
        if (inputTiposResolve == "5" && inputTotalResolve == "35")
        {
            Debug.Log("merequetengue");
        }
    }
}
