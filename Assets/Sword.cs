using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : PlayerStats
{


    [SerializeField] private UI label;


    private void OnGUI()
    {
        if (GUI.Button(new Rect(177, 97, 275, 46), "SwordMan"))
        {
            label.Details = ("Health: " + Health + "\nMana: " + Mana + "\nAttack: " + Attack + "\nDefense: " + Defense + "\nSpeed: " + Speed);
        }


    }
}
