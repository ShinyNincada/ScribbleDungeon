using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemSO> itemList = new List<ItemSO>();
    

    public void Add(ItemSO newItem){
        itemList.Add(newItem);
    }

    public void Remove(ItemSO newItem) {
        itemList.Remove(newItem);
    }
  
    public bool ContainsItem(ItemSO item)
    {
        return itemList.Contains(item);
    }
}
