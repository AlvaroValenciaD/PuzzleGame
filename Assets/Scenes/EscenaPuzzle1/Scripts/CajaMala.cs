using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CajaMala : MonoBehaviour
{
    [SerializeField] GameManagerSO gM;
    [SerializeField] GameObject Pill;
    [SerializeField] Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5;
    [SerializeField] CanvasManager canvas;
    [SerializeField] GameObject pildoras, acertaste, resolverText;
    [SerializeField] Material mat;
    bool functionOnce = false;
    bool resolver = false;

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
            canvas.SetNumCapsulas(0);
            pildoras.SetActive(true);
            functionOnce = true;
        }
        if (resolver)
        {
            Debug.Log("Me tocaste");
            resolver = false;
            acertaste.SetActive(true);
            resolverText.SetActive(false);
        }
    }

    public void Resolver() 
    {
        resolver = true; functionOnce = true; 
    }

    public void CargarEscena()
    {
        SceneManager.LoadScene(1);
    }


}
