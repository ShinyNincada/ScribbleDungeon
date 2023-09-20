using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    private List<Item> itemList = new List<Item>();
    [SerializeField] private Inventory_UI inventory_UI;


    
    public void AddItem(Item item) {
        itemList.Add(item);
        inventory_UI.SetInventory(this);
        
    }

    public List<Item> GetItemList(){
        return itemList;
    }
    
    
}