using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemPool", menuName = "Scriptable Object/ItemPool", order = 2)]
public class ItemPool : ScriptableObject
{
    public ItemSO[] myItems;
}
