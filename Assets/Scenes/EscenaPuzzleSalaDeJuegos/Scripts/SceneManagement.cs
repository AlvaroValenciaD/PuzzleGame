using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] int scene;
    public void SceneMovement() { SceneManager.LoadScene(scene); }
}