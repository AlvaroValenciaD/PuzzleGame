using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    List<Item> Items = new List<Item>();

    //public Transform ItemContent;
    //public GameObject InventoryItem;

    //[SerializeField] Item[] items;
    [SerializeField] GameObject[] itemsSlots;

    [SerializeField] GameObject fondoDescription;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Add(Item item)
    {
        Items.Add(item);
        Image iconSlot = itemsSlots[Items.Count - 1].transform.GetChild(0).GetComponentInChildren<Image>();
        iconSlot.sprite = Items[Items.Count - 1].icon;

        for (int i = 0; i < itemsSlots.Length; i++)
        {
            if (itemsSlots[Items.Count].activeSelf == false)
            {
                itemsSlots[Items.Count].SetActive(true);
                
            }
            
        }
    }

    
    //SE ENSEÑA LA DESCRIPCIÓN DEL OBJETO
    public void OnClickItemButton(int id)
    {
        //GameObject obj = Instantiate(InventoryItem, ItemContent);
        //var itemIcon = obj.transform.GetChild(0).GetComponentInChildren<Image>();
        //itemIcon.sprite = Items[id].icon;
        fondoDescription.SetActive(true);
        TextMeshProUGUI itemDescription = fondoDescription.GetComponentInChildren<TextMeshProUGUI>();
        itemDescription.text = Items[id].description;
    }

    //public void ListItem()
    //{
    //    foreach (Transform item in ItemContent)
    //    {
    //        Destroy(item.gameObject);//Para "limpiar" el inventario, ya que cada vez que se abría, se duplicaba el objeto.
    //        //Aún no puesto en práctica.
    //    }

    //    //Tras esto hay que ir al "boton" del inventario y añadir el "InventoryManager" y activar el método "ListItem".
    //    //En el Inventorymanager, localizar el ItemContent y el InventoryItem.
    //    //Posiblemente haya un error dentro del Método ListItem y haya que arreglarlo.(Borrar Item de ambos var)
    //}
}
