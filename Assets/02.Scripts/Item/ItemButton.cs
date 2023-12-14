using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton: MonoBehaviour
{
    //아이템 클릭 시에 장비인지 소모품인지 확인하고
    //장비인 경우에는 장착할 수 있게,
    //소모품인 경우에는 소모 시에 사라지게 만들기

    public GameObject CheckWindow;
    public TextMeshProUGUI CheckItemName;
    public TextMeshProUGUI CheckItemDescription;
    public Image CheckItemImage;
    public TextMeshProUGUI ConfirmText;

    public ItemSlot itemslot;
    public ItemButton itemButton;
    public Image itemIcon;
    public GameObject Equip;

    public Button YesButton;

    public void PressItem(ItemSlot slot)
    {
        // 만약 EquipCheck가 켜져있으면 꺼주고 꺼져있으면 켜주게
        // 이후에 해당 Equip 아이템의 능력치를 Status에 추가되고 빠지게

        CheckItemName.text = slot.inputData.itemName;
        CheckItemDescription.text = slot.inputData.description;
        CheckItemImage.sprite = slot.inputData.itemIcon;

        CheckWindow.SetActive(true);

        if (slot.inputData.isEquiped)
        {
            ConfirmText.text = "해제하시겠습니까?";
            YesButton.onClick.RemoveAllListeners();
            YesButton.onClick.AddListener(() =>
            {
                slot.inputData.isEquiped = false;
                slot.CheckEquip();
            });
        }
        else
        {
            ConfirmText.text = "장착하시겠습니까?";
            YesButton.onClick.RemoveAllListeners();
            YesButton.onClick.AddListener(() =>
            {
                slot.inputData.isEquiped = true;
                slot.CheckEquip();
            });
         }
    }
}
