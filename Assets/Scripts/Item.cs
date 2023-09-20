using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
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
    }
}

public enum ItemType {
    Weapon,
    Comsumable,
    Medkit,
    Coin
}
