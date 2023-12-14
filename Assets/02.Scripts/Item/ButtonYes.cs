using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonYes : MonoBehaviour
{
    public GameObject Equip;
    public GameObject CheckWindow;

    public void PressYesButton()
    {
        CheckWindow.SetActive(false);

        EquipCheck(!Equip.gameObject.activeSelf);
    }
    private void EquipCheck(bool isActive)
    {
        if (Equip != null)
        {
            Equip.gameObject.SetActive(isActive);
        }
    }
}
