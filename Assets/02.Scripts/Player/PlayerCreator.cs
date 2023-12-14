using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCreator : MonoBehaviour
{
    public TextMeshProUGUI PlayerTitle;
    public TextMeshProUGUI PlayerName;
    public TextMeshProUGUI PlayerLevel;
    public TextMeshProUGUI PlayerExp;
    public TextMeshProUGUI PlayerExplain;
    public TextMeshProUGUI PlayerGold;
    public TextMeshProUGUI PlayerAtk;
    public TextMeshProUGUI PlayerDef;
    public TextMeshProUGUI PlayerHP;
    public TextMeshProUGUI PlayerCri;

    public ExpBar expBar;

    public void MakeNewPlayer(Player player)
    {
        player.Title = "새벽의 악마";
        player.Name = "클루티스";
        player.Level = 1635;
        player.Exp = 35;
        player.Explain = "스파르타 코딩클럽 유니티 과정을 진행하면서 칭호 값을 못하고 12시면 잠드는 로악귀입니다";
        player.Gold = 20000;
        player.Atk = 100;
        player.Def = 50;
        player.HP = 500;
        player.Cri = 88;

        PlayerTitle.text = player.Title;
        PlayerName.text = player.Name;
        PlayerLevel.text = player.Level.ToString();
        PlayerExp.text = player.Exp.ToString();
        PlayerExplain.text = player.Explain;
        PlayerGold.text = player.Gold.ToString();
        PlayerAtk.text = player.Atk.ToString();
        PlayerDef.text = player.Def.ToString();
        PlayerHP.text = player.HP.ToString();
        PlayerCri.text = player.Cri.ToString();

        expBar.UpdateExpBar();
    }
}
