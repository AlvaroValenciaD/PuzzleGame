using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;

public class PuzzleStarManager : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI inputTipos;
    [SerializeField] TextMeshProUGUI inputTotal;
    [SerializeField] GameObject acertaste;
    [SerializeField] GameObject fallaste;
    string inputTiposString, inputTotalString;


    private void Update()
    {

        
    }
    public void Resolver()
    {
        inputTipos.text.Trim();
        inputTotal.text.Trim();
        Debug.Log(">" + inputTipos.text + "< Length: " + inputTipos.text.Length);
        Debug.Log(">" + inputTotal.text + "< Length: " + inputTotal.text.Length);

        if (inputTipos.text == "5" && inputTotal.text == "35")
        {
            Debug.Log("merequetengue");
        }
        else
        {
            Debug.Log("Porque em haces esto");
        }
    }
}
