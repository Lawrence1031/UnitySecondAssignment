using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonYes : MonoBehaviour
{
    public GameObject Equip;

    public void PressYesButton(ItemSlot slot)
    {
        if (slot.inputData.isEquiped)
        {
            slot.inputData.isEquiped = false;
        }
        else
        {
            slot.inputData.isEquiped = true;
        }

        slot.CheckEquip();
    }
}
