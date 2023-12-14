using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager instance;

    public PlayerSO playerSO;
    public ItemPool itemPool;

    private void Awake()
    {
        instance = this;
    }
}
