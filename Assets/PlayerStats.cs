using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerStats : MonoBehaviour
{
    [SerializeField] protected int Health;
    [SerializeField] protected int Mana;
    [SerializeField] protected int Attack;
    [SerializeField] protected int Defense;
    [SerializeField] protected int Speed;

   
    public GUIStyle Gui;
  

}
