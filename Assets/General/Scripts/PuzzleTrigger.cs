using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTrigger : MonoBehaviour
{
    [SerializeField] int puzzle;

    public void ActivePuzzle()
    {
        SceneManager.LoadScene(puzzle);
    }
}
