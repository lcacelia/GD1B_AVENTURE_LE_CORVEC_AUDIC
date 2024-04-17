using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName ="Inventory/Item")]
public class Item : ScriptableObject
{
    public int id;
    public string nom;
    public string description;
    public Sprite image;
    public int hpGiven;
    public int speedGiven;
    public float speedDuration;


}
