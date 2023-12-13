using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerCreator playerCreator;

    void Start()
    {
        if (playerCreator != null)
        {
            Player player = new Player();

            playerCreator.MakeNewPlayer(player);
        }
    }
}
