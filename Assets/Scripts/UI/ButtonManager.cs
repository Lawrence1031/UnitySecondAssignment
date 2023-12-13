using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject StatusButton;
    public GameObject StatusBoard;
    public GameObject InventoryButton;
    public GameObject InventoryBoard;
    public GameObject InventoryPrevButton;
    public GameObject InventoryNextButton;
    public GameObject InventorySlot1;
    public GameObject InventorySlot2;
    public GameObject InventorySlot3;
    public GameObject InventorySlot4;
    public GameObject InventorySlot5;
    public GameObject backButton;

    // 시작 시에 StatusBoard, InventoryBoard, backButton false로
    // StatusButton을 누르면 StatusBoard, backButton true
    // InventoryButton을 누르면 InventoryBoard, backButton true
    // backButton을 누르면 StatusBoard와 InventoryBoard를 검사해서 true면 false로, backButton을 false로


    private void Awake()
    {
        StatusBoard.SetActive(false);
        InventoryBoard.SetActive(false);
        backButton.SetActive(false);
        InventorySlot1.SetActive(false);
        InventorySlot2.SetActive(false);
        InventorySlot3.SetActive(false);
        InventorySlot4.SetActive(false);
        InventorySlot5.SetActive(false);
    }

    public void ClickStatus()
    {
        StatusBoard.SetActive(true);
        backButton.SetActive(true);
    }

    public void ClickInventory()
    {
        InventoryBoard.SetActive(true);
        backButton.SetActive(true);
    }

    public void ClickBack()
    {
        if (StatusBoard.activeSelf)
            StatusBoard.SetActive(false);

        if (InventoryBoard.activeSelf)
            InventoryBoard.SetActive(false);

        backButton.SetActive(false);
    }
}
