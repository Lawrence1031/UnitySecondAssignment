using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton: MonoBehaviour
{
    //아이템 클릭 시에 장비인지 소모품인지 확인하고
    //장비인 경우에는 장착할 수 있게,
    //소모품인 경우에는 소모 시에 사라지게 만들기
    
    public TextMeshProUGUI ItemName;
    public TextMeshProUGUI ItemDescription;

    public GameObject CheckWindow;
    public TextMeshProUGUI CheckItemName;
    public TextMeshProUGUI CheckItemDescription;
    public Image CheckItemImage;
    public TextMeshProUGUI ConfirmText;

    [HideInInspector] public ItemSO inputData;

    public ItemButton itemButton;
    public Image itemIcon;
    public GameObject Equip;

    public void Init(ItemSO data)
    {
        inputData = data;
        itemIcon.sprite = data.itemIcon;
        itemIcon.enabled = true;

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

    public void PressItem()
    {
        // 만약 EquipCheck가 켜져있으면 꺼주고 꺼져있으면 켜주게
        // 이후에 해당 Equip 아이템의 능력치를 Status에 추가되고 빠지게

        CheckWindow.SetActive(true);
        CheckItemName.text = ItemName.text;
        CheckItemDescription.text = ItemDescription.text;
        //CheckItemImage = ItemImage.GetComponent<Image>();

        if (inputData.isEquiped)
        {
            ConfirmText.text = "해제하시겠습니까?";
        }
        else
        {
            ConfirmText.text = "장착하시겠습니까?";
        }

        CheckEquip();
    }

    public void PressYesButton()
    {
        CheckEquip();
    }
}
