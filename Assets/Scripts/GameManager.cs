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
            Player player = new Player
            {
                Title = "새벽의 악마",
                Name = "클루티스",
                Level = 1635,
                Exp = 35,
                Explain = "스파르타 코딩클럽 유니티 과정을 진행하면서 \n" +
                                    "칭호 값을 못하고 12시면 잠드는 로악귀입니다",
                Gold = 20000,
                Atk = 100,
                Def = 50,
                HP = 500,
                Cri = 88,
            };

            playerCreator.MakeNewPlayer(player);
        }
    }
}
