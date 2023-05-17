using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GDTClock : MonoBehaviour
{

    [SerializeField]
    private GameObject hourHand;
    [SerializeField]
    private GameObject minuteHand;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTime(int hour, int minute)
    {

        if(hour>=0 && hour < 24)
        {
            if (hour > 12)
            {
                hour -= 12;
            }
            hourHand.transform.localEulerAngles = new Vector3(0,0,(hour+minute/60f)*360f/12f);

        }

        if(minute>=0&& minute < 60)
        {
            minuteHand.transform.localEulerAngles = new Vector3(0, 0, minute * 360f / 60f);
        }

    }


}
