using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    private void Awake()
    {
        Instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }

    public void ListItem()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);//Para "limpiar" el inventario, ya que cada vez que se abría, se duplicaba el objeto.
            //Aún no puesto en práctica.
        }
        foreach (var item in Items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            //var itemName = obj.transform.Find("Item/ItemName").GetComponent<Text>();
            //var itemIcon = obj.transform.Find("Item/ItemIcon").GetComponent<Image>();
            //itemName.text = item.itemName;
            //itemIcon.sprite = item.icon;
        } //Tras esto hay que ir al "boton" del inventario y añadir el "InventoryManager" y activar el método "ListItem".
        //En el Inventorymanager, localizar el ItemContent y el InventoryItem.
        //Posiblemente haya un error dentro del Método ListItem y haya que arreglarlo.(Borrar Item de ambos var)
    }
}
