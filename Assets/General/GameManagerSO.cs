using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName ="ScriptableObjects/Game Manager")]
public class GameManagerSO : ScriptableObject
{
    [SerializeField] private int indexPuertaObjetivo = -1;

    //private void OnEnable()
    //{
    //    SceneManager.sceneLoaded += SceneManager_sceneLoaded;
        
    //}

    //private void SceneManager_sceneLoaded(Scene escenaCargada, LoadSceneMode sceneMode)
    //{
    //    Debug.Log("Nueva escena!");
    //    if (indexPuertaObjetivo == -1) return;

    //    Door[] doors = FindObjectsOfType<Door>();
    //    GameObject player = GameObject.FindWithTag("Player");
    //    foreach (Door door in doors)
    //    {
    //        if(door.GetIndexDoor() == indexPuertaObjetivo)
    //        {
    //            Debug.Log("Vete a la puerta " + door.GetIndexDoor() + " de la escena " + escenaCargada.name);
    //            player.transform.position = door.GetSpawnPoint().position;
    //            player.transform.eulerAngles = door.GetSpawnRotation();
    //            break;
    //        }
    //    }
    //}

    public int GetIndexPuertaObjetivo()
    {
        return indexPuertaObjetivo;
    }
    public void CargarEscena(int indexEscena, int indexPuerta)
    {
        indexPuertaObjetivo = indexPuerta;
        SceneManager.LoadScene(indexEscena);
    }
}
