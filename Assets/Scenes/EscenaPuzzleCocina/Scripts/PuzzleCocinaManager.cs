using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleCocinaManager : MonoBehaviour
{
    public void EndPuzzle() { SceneManager.LoadScene(5); }
}
