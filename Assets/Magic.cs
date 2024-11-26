using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : PlayerStats
{
    [SerializeField] private UI label;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(177, 202, 275, 46), "Wizard"))
        {
            label.Details = ("Health: " + Health + "\nMana: " + Mana + "\nAttack: " + Attack + "\nDefense: " + Defense + "\nSpeed: " + Speed);
        }
    }
}
