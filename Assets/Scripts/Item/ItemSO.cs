using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable
}

public enum ConsumableType
{
    Health,
    Exp
}

[System.Serializable]
public class ItemSOConsumable
{
    public ConsumableType type;
    public float value;
}


[CreateAssetMenu(fileName = "ItemSO", menuName = "Item", order = 0)]
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

    [Header("Consumable")]
    public ConsumableType[] consumables;
}
