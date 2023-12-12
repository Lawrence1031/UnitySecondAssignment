using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Object/Item", order = int.MaxValue)]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
    public int price;
}
