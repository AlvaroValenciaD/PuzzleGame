using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Diálogo")]
public class DialogoSO : ScriptableObject
{
    public int numeroDeActo;
    [TextArea(1, 1000)]public string[] frases;
}
