using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}

public enum ConsumableType
{
    HP,
    Exp
}

[System.Serializable]
public class ItemSOConsumable
{
    public ConsumableType type;
    public float value;
}


[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/Item", order = 0)]
public class ItemSO : ScriptableObject
{
    [Header("info")]
    public string itemName;
    public string description;
    public ItemType type;
    public Sprite itemIcon;
    public int price;

    [Header("Equipable")]
    public bool equipable;
    public int Atk;
    public int Def;
    public int HP;
    public int Cri;

    [Header("Consumable")]
    public ItemSOConsumable[] consumables;



    public void ItemInfo()
    {
        Debug.Log("아이템 이름 : " + itemName);
        Debug.Log("아이템 설명 : " + description);
        Debug.Log("아이템 종류 : " + type);
        Debug.Log("아이템 가격 : " + price);
        Debug.Log("착용 가능여부 : " + equipable);
        Debug.Log("사용 가능여부 : " + consumables);
        Debug.Log("사용 시 획득 HP : " + ConsumableType.HP);
        Debug.Log("사용 시 획득 EXP : " + ConsumableType.Exp);
    }
}
