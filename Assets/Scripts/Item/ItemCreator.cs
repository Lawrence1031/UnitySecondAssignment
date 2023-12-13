using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreator : MonoBehaviour
{
    List<Item> itemInventory = new List<Item>();
    public ItemSO[] itemDB;
    public void ItemCreate(ItemType inputWeaponType)
    {
        int itemIndex = (int)inputWeaponType;

        GameObject itemGO = new GameObject(inputWeaponType.ToString());
        itemGO.transform.parent = this.gameObject.transform;

        Item item = itemGO.AddComponent<Item>();

        item.itemName = itemDB[itemIndex].itemName;
        item.itemIcon = itemDB[itemIndex].itemIcon;
        item.price = itemDB[itemIndex].price;

        itemInventory.Add(item);
    }

    void Start()
    {
        ShowInventoryItems();
    }

    void ShowInventoryItems()
    {
        foreach (Item i in itemInventory)
        {
            Debug.Log(i.itemName + " price:" + i.price);            
        }
    }
}
