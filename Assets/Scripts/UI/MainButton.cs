using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainButton : MonoBehaviour
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
        backButton.SetActive(false);
    }

    public void ClickStatus()
    {
        StatusBoard.SetActive(true);
        backButton.SetActive(true);
    }

    public void ClickBack()  // Status 분리 시에 가져가면서 없애기
    {
        if (StatusBoard.activeSelf)
            StatusBoard.SetActive(false);

        if (InventoryBoard.activeSelf)
            InventoryBoard.SetActive(false);

        backButton.SetActive(false);
    }
}