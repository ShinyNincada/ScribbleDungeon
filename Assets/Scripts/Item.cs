using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public ItemType itemType;
    public int amount;
}

public enum ItemType {
    Weapon,
    Comsumable,
    Medkit,
    Coin
}
