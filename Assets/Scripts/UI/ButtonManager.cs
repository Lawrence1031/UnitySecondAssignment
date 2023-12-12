using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject StatusButton;
    public GameObject StatusBoard;
    public GameObject InventoryButton;
    public GameObject InventoryBoard;
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
