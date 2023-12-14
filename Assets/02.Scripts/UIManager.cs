using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    // 인벤토리를 열었을 때, 아이템 슬롯에 아이템 정보들이 들어가야함.
    public ItemSlot[] itemslots;

    public void SetInventory()
    {
        for (int i = 0; i < DataManager.instance.itemPool.myItems.Length; i++)
        {
            itemslots[i].Init(DataManager.instance.itemPool.myItems[i]);
        }
    }
}
