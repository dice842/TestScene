using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HPManager : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private int currentHP;

    private void Start()
    {
        textMeshPro = transform.GetComponentInChildren<TextMeshProUGUI>();
        currentHP = int.Parse(textMeshPro.text);
    }
    public void Damage()
    {
        if (currentHP >= 10) currentHP -= 10;
        else if (currentHP > 0) currentHP = 0;
        else return;
        textMeshPro.text = currentHP.ToString();
    }
}
