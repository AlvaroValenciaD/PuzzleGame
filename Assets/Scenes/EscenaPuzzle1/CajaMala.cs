using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMala : MonoBehaviour
{
    [SerializeField] GameObject Pill;
    [SerializeField] Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5;
    [SerializeField] CanvasManager canvas;
    [SerializeField] GameObject pildoras;
    [SerializeField] Material mat;
    bool functionOnce = false;

    public void GeneratePill()
    { 
        float numPildoras = canvas.GetNumCapsulas();
        if (numPildoras == 0f)
        {
            numPildoras = 1f;
        }
        
        if (numPildoras == 1f)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            numPildoras = 0;
            Debug.Log(numPildoras);
        }
        else if (numPildoras == 2)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            numPildoras = 0;
            Debug.Log(numPildoras);
        }
        else if (numPildoras == 3)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy3.GetComponent<MeshRenderer>().sharedMaterial = mat;
            numPildoras = 0;
            Debug.Log(numPildoras);
        }
        else if (numPildoras == 4)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
            GameObject PillCopy4 = Instantiate(Pill, spawnPoint4.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy3.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy4.GetComponent<MeshRenderer>().sharedMaterial = mat;
            numPildoras = 0;
            Debug.Log(numPildoras);
        }
        else if (numPildoras == 5)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
            GameObject PillCopy4 = Instantiate(Pill, spawnPoint4.position, Quaternion.identity);
            GameObject PillCopy5 = Instantiate(Pill, spawnPoint5.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy3.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy4.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy5.GetComponent<MeshRenderer>().sharedMaterial = mat;
            numPildoras = 0;
            Debug.Log(numPildoras);
        }
    }

    private void OnMouseDown()
    {
        if (!functionOnce)
        {
        pildoras.SetActive(true);
        functionOnce = true;
        }
    }
}
