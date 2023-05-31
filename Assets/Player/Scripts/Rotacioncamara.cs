using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacioncamara : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (h != 0 || v != 0)
        {
            RotateLookDirection();
        }
    }

    void RotateLookDirection()
    {
        float ang = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, ang, 0);
    }
}
