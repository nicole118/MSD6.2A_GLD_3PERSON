using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// -- create a menu from all these variables
[CreateAssetMenu(fileName = "GameItem", menuName = "Game Items/Create Game Item")] 
public class ItemScriptableObject : ScriptableObject
{
    public enum Type
    {
        Health,
        Mana
    } 

    public string title;
    public Sprite icon;
    public int increaseValue;
    public Type type;

    
}
