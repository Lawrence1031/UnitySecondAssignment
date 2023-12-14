using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemSort
{
    Bow, Carrot, Sword, Wand
}
public class ItemCreator : MonoBehaviour
{
    [SerializeField]
    private List<ItemSO> ItemSO;
    [SerializeField]
    private GameObject ItemSlot;

    public void CreateItem()
    {
        for(int i = 0; i < ItemSO.Count; i++)
        {
            var item = ItemCreate((ItemSort)i);
        }
    }

    public Item ItemCreate(ItemSort sort)
    {
        var newItem = Instantiate(ItemSlot).GetComponent<Item>();
        //newItem.itemIcon = items[(int)sort];  // 이후에 아이콘 추가시 수정
        newItem.itemName = ItemSO[(int)sort].ToString();
        return newItem;
    }
}



//void oldMethod()
//{
//    List<Item> itemInventory = new List<Item>();
//    public ItemSO[] itemDB;
//    public void ItemCreate(ItemType inputWeaponType)
//    {
//        int itemIndex = (int)inputWeaponType;

//        GameObject itemGO = new GameObject(inputWeaponType.ToString());
//        itemGO.transform.parent = this.gameObject.transform;

//        Item item = itemGO.AddComponent<Item>();

//        item.itemName = itemDB[itemIndex].itemName;
//        item.itemIcon = itemDB[itemIndex].itemIcon;
//        item.price = itemDB[itemIndex].price;

//        itemInventory.Add(item);
//    }

//    void Start()
//    {
//        ShowInventoryItems();
//    }

//    void ShowInventoryItems()
//    {
//        foreach (Item i in itemInventory)
//        {
//            Debug.Log(i.itemName + " price:" + i.price);
//        }
//    }
//}
