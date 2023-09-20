using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public ItemName itemName;
    public ItemSO itemSO;
    public int amount;
    public bool stackable;

    public Item()
    {
    }

    public Item(ItemSO itemSO, int amount)
    {
        this.itemSO = itemSO;
        this.amount = amount;
        itemName = itemSO.itemName;
        stackable = itemSO.stackable;
    }
}

public enum ItemType {
    Weapon,
    Comsumable,
    Medkit,
    Coin
}

public enum ItemName {
    Gun, 
    Bow,
    Bandage,
    Trap
}