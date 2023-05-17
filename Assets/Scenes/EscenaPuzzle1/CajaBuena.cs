 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaBuena : MonoBehaviour
{
    [SerializeField] GameObject Pill;
    [SerializeField] Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5;

    void GeneratePill()
    {
        GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
        GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
        GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
        GameObject PillCopy4 = Instantiate(Pill, spawnPoint4.position, Quaternion.identity);
        GameObject PillCopy5 = Instantiate(Pill, spawnPoint5.position, Quaternion.identity);
    }
}
