using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    
    
        private string Details;

    private void OnGUI()
    {
        if (GUI.Button(new Rect(256, 394, 237, 95), "Chest"))
        {
            Details = "Coin";
        }


        if(GUI.Button(new Rect(935, 400, 237, 95), "Switch"))
        {
            Details = "Door Open";
        }


        GUI.Label(new Rect(591, 580, 250, 95), Details);
    }


}
