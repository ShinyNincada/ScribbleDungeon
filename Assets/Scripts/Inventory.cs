using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;
    [SerializeField] private List<ItemSO> itemList = new List<ItemSO>();
    [SerializeField] private int maxCapacity = 100; 
    
    private void Awake() {
        if(Instance == null) {
            Instance = this;
        }
        else {
            Debug.LogError("Another instance existed!!");
        }
    }

    public bool Add(ItemSO newItem){
        if(itemList.Count < maxCapacity) {
            itemList.Add(newItem);
            return true;
        }
        else{
            return false;
        }
    }

    public void Remove(ItemSO newItem) {
        itemList.Remove(newItem);
    }
  
    public bool ContainsItem(ItemSO item)
    {
        return itemList.Contains(item);
    }
}
