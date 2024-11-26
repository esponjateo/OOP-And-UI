using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : PlayerStats
{
    [SerializeField] private UI label;
    private void OnGUI()
    {


        if (GUI.Button(new Rect(177, 151, 275, 46), "Archer"))
        {
            label.Details = ("Health: " + Health + "\nMana: " + Mana + "\nAttack: " + Attack + "\nDefense: " + Defense + "\nSpeed: " + Speed);
        }
    }

}
