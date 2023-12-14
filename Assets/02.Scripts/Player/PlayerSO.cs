using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Scriptable Object/Player", order = 1)]
public class PlayerSO : ScriptableObject
{
    [Header("info")]
    public string Title;
    public string Name;
    public int Level;
    public int Exp;
    public string Explain;

    public int Gold;

    [Header("Status")]
    public int Atk;
    public int Def;
    public int HP;
    public int Cri;
}
