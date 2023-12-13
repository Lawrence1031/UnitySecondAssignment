using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EquipItemButton : MonoBehaviour
{
    //아이템 클릭 시에 장비인지 소모품인지 확인하고
    //장비인 경우에는 장착할 수 있게,
    //소모품인 경우에는 소모 시에 사라지게 만들기

    public GameObject Equip;
    public TextMeshProUGUI ItemName;
    public TextMeshProUGUI ItemDescription;
    public Image ItemImage;

    public GameObject CheckWindow;
    public TextMeshProUGUI CheckItemName;
    public TextMeshProUGUI CheckItemDescription;
    public Image CheckItemImage;
    public TextMeshProUGUI ConfirmText;

    private void Start()
    {
        Equip.SetActive(false);
    }


    public void PressItem()
    {
        // 만약 EquipCheck가 켜져있으면 꺼주고 꺼져있으면 켜주게
        // 이후에 해당 Equip 아이템의 능력치를 Status에 추가되고 빠지게

        CheckWindow.SetActive(true);
        CheckItemName.text = ItemName.text;
        CheckItemDescription.text = ItemDescription.text;
        CheckItemImage = ItemImage.GetComponent<Image>();

        if (!Equip.gameObject.activeSelf)
        {
            ConfirmText.text = "장착하시겠습니까?";
        }
        else
        {
            ConfirmText.text = "해제하시겠습니까?";
        }
    }

    public void PressYesButton()
    {
        EquipCheck(!Equip.gameObject.activeSelf);
        CheckWindow.SetActive(false);
    }

    public void PressNoButton()
    {
        CheckWindow.SetActive(false);
    }

    private void EquipCheck(bool isActive)
    {
        if (Equip != null)
        {
            Equip.gameObject.SetActive(isActive);
        }
    }
}
