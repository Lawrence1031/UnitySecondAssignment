using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [HideInInspector] public ItemSO inputData;

    public ItemButton itemButton;
    public Image itemIcon;
    public GameObject Equip;

    public void Init(ItemSO data)
    {
        inputData = data;
        itemIcon.sprite = data.itemIcon;

        CheckEquip();
    }

    public void CheckEquip()
    {
        if (inputData.isEquiped)
        {
            Equip.SetActive(true);
        }
        else
        {
            Equip.SetActive(false);
        }
    }

    public void PopUp()
    {
        itemButton.PressItem();
    }
}
