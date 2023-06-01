using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{
    [SerializeField] GameObject cameraPoint;
    [SerializeField] GameObject backButton;
    public void CameraChangeOn() { cameraPoint.SetActive(true); }
    public void CameraChangeOff() { cameraPoint.SetActive(false); }
}
