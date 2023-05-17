using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallClockTest : MonoBehaviour
{

    private GDTClock clock;

    // Start is called before the first frame update
    void Start()
    {
        clock = FindObjectOfType<GDTClock>();
        InvokeRepeating("SetRandomTime",0,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetRandomTime()
    {
        int hour = Random.Range(0,23);
        int minute = Random.Range(0, 59);
        Debug.Log("Current Time: " + hour + ":" + minute);
        clock.SetTime(hour, minute);
        
    }

}
