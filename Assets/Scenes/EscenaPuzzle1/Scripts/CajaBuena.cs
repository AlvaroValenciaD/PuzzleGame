 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CajaBuena : MonoBehaviour
{
    [SerializeField] GameObject Pill;
    [SerializeField] Transform spawnPoint1, spawnPoint2, spawnPoint3, spawnPoint4, spawnPoint5;
    [SerializeField] CanvasManagerPuzzleCocina canvas;
    [SerializeField] GameObject pildoras, fallaste, resolverText;
    [SerializeField] Material mat;
    bool functionOnce = false;
    bool resolver = false;

    public void GeneratePill()
    {

        float numPildoras = canvas.GetNumCapsulas();
        if (numPildoras == 0f) { numPildoras = 1f; }
        if (numPildoras == 1f)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            Debug.Log(numPildoras);
            numPildoras = 0f;
        }
        else if (numPildoras == 2f)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            Debug.Log(numPildoras);
            numPildoras = 0;
        }
        else if (numPildoras == 3f)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy3.GetComponent<MeshRenderer>().sharedMaterial = mat;
            Debug.Log(numPildoras);
            numPildoras = 0f;
        }
        else if (numPildoras == 4f)
        {
            GameObject PillCopy1 = Instantiate(Pill, spawnPoint1.position, Quaternion.identity);
            GameObject PillCopy2 = Instantiate(Pill, spawnPoint2.position, Quaternion.identity);
            GameObject PillCopy3 = Instantiate(Pill, spawnPoint3.position, Quaternion.identity);
            GameObject PillCopy4 = Instantiate(Pill, spawnPoint4.position, Quaternion.identity);
            PillCopy1.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy2.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy3.GetComponent<MeshRenderer>().sharedMaterial = mat;
            PillCopy4.GetComponent<MeshRenderer>().sharedMaterial = mat;
            Debug.Log(numPildoras);
            numPildoras = 0f;
        }
        else if (numPildoras == 5f)
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
            Debug.Log(numPildoras);
            numPildoras = 0f;
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
            fallaste.SetActive(true);
            resolverText.SetActive(false);
        }
    }

    public void Resolver() { resolver = true; functionOnce = true; }

    public void Restart() { SceneManager.LoadScene(6);}

}
