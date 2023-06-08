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
    string tipos, total;


    private void Update()
    {

        
    }
    public void Resolver()
    {

        tipos = inputTipos.text.Substring(0, inputTipos.text.Length - 1);
        total = inputTotal.text.Substring(0, inputTotal.text.Length - 1);

        Debug.Log(">" + inputTipos.text + "< Length: " + inputTipos.text.Length);
        Debug.Log(">" + inputTotal.text + "< Length: " + inputTotal.text.Length);

        if (tipos == "5" && total == "35")
        {
            Debug.Log("merequetengue");
            acertaste.SetActive(true);
        }
        else
        {
            Debug.Log("Porque me haces esto");
            fallaste.SetActive(true);
        }
    }
}
