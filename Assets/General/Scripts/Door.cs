using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] int doorIndex;

    public int GetNewLvlIndex()
    {
        return doorIndex;
    }
}
