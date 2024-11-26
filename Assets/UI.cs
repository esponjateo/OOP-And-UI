using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{

    public GUIStyle Gui;

    public Vector2 X;
    public Vector2 Y;

    public string Details = "Health: \nMana: \nAttack: \nDefense: \nSpeed: ";

    private void OnGUI()
    {
        GUI.TextArea(new Rect(X, Y), "");

        /*"Health: \nMana: \nAttack: \nDefense: \nSpeed"*/
            
        GUI.Label(new Rect(570, 91, 809, 162), Details, Gui);

        

        GUI.Label(new Rect(43, 27, 466, 54), "Choose Your Characters", Gui);
    }
}
