using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    private List<Item> itemList = new List<Item>();
    [SerializeField] private Inventory_UI inventory_UI;

    int currentWeaponCount = 2;

    private void Start() {
        inventory_UI.SetInventory(this);
    }
    
    public void AddItem(Item newItem) {
        if(newItem.itemSO.itemType == ItemType.Weapon && currentWeaponCount < 2) {
            
        }
        else {
            return;
        }
        if(newItem.stackable) {
            bool alreadyExists = false;
            foreach(Item item in itemList){
                if(item.itemName.ToString() == newItem.itemName.ToString()) {
                    alreadyExists = true;
                    item.amount += newItem.amount;
                    break;
                }
            }
            
            if(alreadyExists == false) itemList.Add(newItem);
        }
        else {
            foreach(Item item in itemList){
                if(item.itemName.ToString() == newItem.itemName.ToString()) {
                    return;
                }
            }
            itemList.Add(newItem);
        }
        inventory_UI.RefreshInventoryItem();        
    }

    public List<Item> GetItemList(){
        return itemList;
    }
    
    
}