using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonOld : MonoBehaviour
{
    public GameObject Equip;

    private void Start()
    {
        Equip.SetActive(false);
    }
    public void PressItem()
    {
        // 만약 EquipCheck가 켜져있으면 꺼주고 꺼져있으면 켜주게
        // 이후에 해당 Equip 아이템의 능력치를 Status에 추가되고 빠지게
        
        if (Equip != null)
        {
            EquipCheck(!Equip.gameObject.activeSelf);
        }        
    }
    private void EquipCheck(bool isActive)
    {
        if (Equip != null)
        {
            Equip.gameObject.SetActive(isActive);
        }
    }
}
