using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    public Scrollbar scrollbar;
    public TextMeshProUGUI curExpText;

    private void Start()
    {
        scrollbar.onValueChanged.AddListener(ExpChanged);
        UpdateExpBar();
    }


    public void ExpChanged(float size)
    {
        float curExp = size * 100f;
        UpdateExpBar();
    }

    public void UpdateExpBar()
    {
        string CurExpString = curExpText.text;
        float curExp;
        if (float.TryParse(CurExpString, out curExp))
        {
            scrollbar.size = curExp / 100f;
        }
    }
}
