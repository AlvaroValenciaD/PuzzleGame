using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balanza : MonoBehaviour
{
    [SerializeField] CanvasManager canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Pesar()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CapsulaBuena"))
        {
        other.GetComponent<CapsulaBuena>().GetPeso();
        }
        else if (other.CompareTag("CapsulaMala"))
        {
            other.GetComponent<CapsulaMala>().GetPeso();
        }
    }

}
