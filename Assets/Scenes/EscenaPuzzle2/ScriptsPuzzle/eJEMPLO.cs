using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eJEMPLO : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().sleepThreshold = Mathf.Infinity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
