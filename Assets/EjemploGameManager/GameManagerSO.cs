using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName ="ScriptableObjects/Game Manager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] private int indexPuertaObjetivo = -1;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        
    }

    private void SceneManager_sceneLoaded(Scene escenaCargada, LoadSceneMode sceneMode)
    {
        if (indexPuertaObjetivo == -1) return;

        Puerta[] puertas = FindObjectsOfType<Puerta>();
        Player player = FindObjectOfType<Player>();
        foreach (Puerta puerta in puertas)
        {
            if(puerta.GetIndexPuerta() == indexPuertaObjetivo)
            {
                player.transform.position = puerta.GetSpawnPoint().position;
                player.transform.eulerAngles = puerta.GetSpawnRotation();
                break;
            }
        }
    }
    public void CargarEscena(int indexEscena, int indexPuerta)
    {
        indexPuertaObjetivo = indexPuerta;
        SceneManager.LoadScene(indexEscena);
    }
}
